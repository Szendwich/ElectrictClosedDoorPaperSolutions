namespace ElectrictClosedDoorPaperSolutions.Extensions
{
    internal class FileExtensions
    {
        public static async Task WriteAllLinesNoNewlineAtTheEndAsync(string path, IEnumerable<string> lines)
        {
            if (path != null)
            {
                if (lines != null)
                {
                    using FileStream fileStream = File.OpenWrite(path);
                    fileStream.SetLength(0);
                    using StreamWriter streamWriter = new(fileStream);
                    if (lines.Any())
                    {
                        var last = lines.Last();
                        foreach (var line in lines)
                        {
                            if (line.Equals(last))
                            {
                                await streamWriter.WriteAsync(line);
                            }
                            else
                            {
                                await streamWriter.WriteLineAsync(line);
                            }
                        }
                    }
                }
                else
                {
                    throw new ArgumentNullException(nameof(lines));
                }
            }
            else
            {
                throw new ArgumentNullException(nameof(path));
            }
        }
    }
}
