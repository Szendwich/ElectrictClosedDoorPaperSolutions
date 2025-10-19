namespace ElectrictClosedDoorPaperSolutionsTest.Helpers
{
    internal class FileHelper
    {
        internal bool CompareFiles(string filePathOfExpectedResult, string tempOutputFile, out int difference)
        {
            using var expectedResultSR = new StreamReader(File.OpenRead(filePathOfExpectedResult));
            using var actualResultSR = new StreamReader(File.OpenRead(tempOutputFile));

            try
            {
                if (expectedResultSR.BaseStream.Length != actualResultSR.BaseStream.Length)
                {
                    difference = -1;
                    return false;
                }
            }
            catch { }

            while (!expectedResultSR.EndOfStream && !actualResultSR.EndOfStream)
            {
                difference = actualResultSR.Read();
                if (expectedResultSR.Read() != difference)
                {
                    return false;
                }
            }

            difference = 0;
            return expectedResultSR.EndOfStream && actualResultSR.EndOfStream;
        }
    }
}
