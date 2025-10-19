using ElectrictClosedDoorPaperSolutions.Extensions;
using System.Text;
using System.Text.RegularExpressions;

namespace ElectrictClosedDoorPaperSolutions
{
    public class Vzh5Solutions
    {
        /// <summary>
        /// Given a text file, the lines of which contain names, each line contains exactly one name.
        /// The names can only contain lowercase and uppercase letters of the English alphabet and spaces.
        /// Write a program that reads the file and writes the names, sorted by name, to another file.
        /// </summary>
        /// <example>
        /// Input
        /// -----
        /// John Doe
        /// Mues Lee
        /// Bruce Lee
        /// Foo Bar
        /// Last Van
        /// 
        /// Output
        /// ------
        /// Bruce Lee
        /// Foo Bar
        /// John Doe
        /// Last Van
        /// Mues Lee
        /// </example>
        public static async Task Fkod51Solution1(string inputFilePath, string outputFilePath)
        {
            var lines = await File.ReadAllLinesAsync(inputFilePath);
            await FileExtensions.WriteAllLinesNoNewlineAtTheEndAsync(outputFilePath, lines.OrderBy(x => x));
        }

        /// <summary>
        /// Given a text file containing a table.
        /// The table has five columns, the columns are separated by one or more tab characters.
        /// The first column contains the names of the competitors, which consist only of lowercase and uppercase letters of the English alphabet and a single space.
        /// Each name consists of exactly one last name and one first name.
        /// The remaining columns contain the time results of each competitor in mm:ss format (minutes and seconds with two digits).
        /// Write a program that writes the data of the podium competitors to another text file.
        /// The format of the output should be as follows: "PLACE;TOTAL".
        /// Please write the name in exactly 30 characters, in case of shorter names, spaces are expected in the remaining places.
        /// It is assumed that the total time does not exceed 100 minutes, and that the names of the competitors are no longer than thirty characters.
        /// In the event of a tie, several competitors may achieve the same position, in which case the program will display all first, second and third place winners in the same way, with position, per row.
        /// </summary>
        /// <example>
        /// Input
        /// -----
        /// John Doe	03:52	03:48	03:51	03:53
        /// Mues Lee	03:42	03:45	03:48	03:55
        /// Bruce Lee	04:01	03:58	03:59	04:02
        /// Foo Bar		03:57	04:00	04:04	03:56
        /// Last Van	03:42	03:43	03:41	03:40
        /// 
        /// Output
        /// ------
        /// 1. Last Van		14:46
        /// 2. Mues Lee		15:10
        /// 3. John Doe		15:24
        /// </example>
        public static void Fkod52Solution1(string inputFilePath, string outputFilePath)
        {
            var lines = File.ReadAllLines(inputFilePath);
            TimeSpan[] timeResults = [TimeSpan.MaxValue, TimeSpan.MaxValue, TimeSpan.MaxValue];
            List<string>[] nameResults = [[], [], []];
            foreach (var line in lines)
            {
                var splittedLine = line.Split('\t', StringSplitOptions.RemoveEmptyEntries);
                var name = splittedLine[0];
                TimeSpan finalTime = new();
                for (int i = 1; i < splittedLine.Length; i++)
                {
                    var minutesSeconds = splittedLine[i].Split(':');
                    finalTime += new TimeSpan(0, int.Parse(minutesSeconds[0]), int.Parse(minutesSeconds[1]));
                }

                for (int i = 0; i < 3; i++) 
                {
                    if (finalTime < timeResults[i])
                    {
                        for (int j = 2; j > i && j >= 1; j--)
                        {
                            timeResults[j] = timeResults[j - 1];
                            nameResults[j] = nameResults[j - 1];
                        }
                        timeResults[i] = finalTime;
                        nameResults[i] = [name];

                        break;
                    }
                    else if (finalTime == timeResults[i])
                    {
                        nameResults[i].Add(name);

                        break;
                    }
                }
            }

            StringBuilder stringBuilder = new();
            for (int i = 0; i < 3; i++)
            {
                foreach(string name in nameResults[i])
                {
                    stringBuilder.Append($"{i + 1}. {name}".PadRight(30)[..29]);
                    stringBuilder.Append($"{timeResults[i].Minutes}:{timeResults[i].Seconds}");
                    stringBuilder.Append(Environment.NewLine);
                }
            }

            File.WriteAllText(outputFilePath, stringBuilder.ToString());
        }

        /// <summary>
        /// Given a file that contains left-aligned text. It is possible that there are multiple spaces between two words.
        /// The output file contains the right-aligned version of the original text!
        /// The last character of the lines should be in the position where the last character of the longest line of the original file was.
        /// The program should remove unnecessary spaces from the words.
        /// </summary>
        /// <example>
        /// Input
        /// -----
        /// - Töltsünk be egy palackkal a jó öreg ó-Janx-szeszbõl
        /// - hangzik a recept.Adjunk hozzá egy rész vizet
        /// a Santagrinus-V tengereibõl.Ó, az a santagrineánus
        /// tengervíz - teszi hozzá a GALAXIS Útikalauz.
        /// Ó, azok a santagrineánus halak!!!
        /// Olvasszunk fel a keverékben három kocka Arcturus
        /// Megagint   - alaposan meg kell jegelni, különben elvész
        /// a benzin! Buborékoltassunk át négy liter falliánus
        /// mocsárgázt a keveréken, mindazon boldog Stopposok
        /// emlékére, akik belepusztultak a gyönyörökbe Fallia
        /// mocsaraiban.
        /// Output
        /// ------
        ///   - Töltsünk be egy palackkal a jó öreg ó-Janx-szeszbõl
        ///          - hangzik a recept.Adjunk hozzá egy rész vizet
        ///      a Santagrinus-V tengereibõl.Ó, az a santagrineánus
        ///            tengervíz - teszi hozzá a GALAXIS Útikalauz.
        ///                       Ó, azok a santagrineánus halak!!!
        ///        Olvasszunk fel a keverékben három kocka Arcturus
        ///   Megagint - alaposan meg kell jegelni, különben elvész
        ///      a benzin! Buborékoltassunk át négy liter falliánus
        ///       mocsárgázt a keveréken, mindazon boldog Stopposok
        ///      emlékére, akik belepusztultak a gyönyörökbe Fallia
        ///                                            mocsaraiban.
        /// </example>
        public static void Fkod53Solution1(string inputFilePath, string outputFilePath)
        {
            var lines = File.ReadAllLines(inputFilePath);
            var longestLine = lines.Select(l => l.Length).Max();
            
            StringBuilder stringBuilder = new();
            RegexOptions options = RegexOptions.None;
            Regex regex = new("[ ]{2,}", options);
            foreach (string line in lines)
            {
                stringBuilder.AppendLine(regex.Replace(line, " ").PadLeft(longestLine)[..(longestLine - 1)]);
            }

            File.WriteAllText(outputFilePath, stringBuilder.ToString());
        }
    }
}
