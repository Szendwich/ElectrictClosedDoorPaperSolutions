using ElectrictClosedDoorPaperSolutions.Extensions;

namespace ElectrictClosedDoorPaperSolutions
{
    public class Vzh3Solutions
    {
        /// <summary>
        /// Write a program that reads real numbers from standard input until EOF. Each line contains exactly one number.
        /// The input can contain any number, but it must contain at least one.
        /// The program writes to standard output the sum of the values ​​that are equal to or less than the average of all numbers read!
        /// Use a linked list to solve this problem!
        /// </summary>
        /// <example>
        /// Input                        Output
        /// 3.6 1.2 5 1.48                 2.68
        /// -5.4 3.2 -524.36 -0 -200    -724.36
        /// </example>
        public static double Fkod31Solution1(IEnumerable<double> numbers)
        {
            return Math.Round(numbers.Where(x => x <= numbers.Average()).Sum(x => x), 2);
        }

        /// <summary>
        /// Write a program that reads characters from standard input up to the * character. The characters can be uppercase and lowercase letters of the English alphabet and the * character.
        /// Each line contains exactly one character.The input can contain any number of characters, but it must contain at least one.
        /// The program writes the characters read in reverse order to the standard output, in a single line, replacing lowercase letters with uppercase letters.
        /// The output also contains the* character! Use a linked list to solve this problem!
        /// </summary>
        /// <example>
        /// Input       Output
        /// *                *
        /// g*              *G
        /// alMa*        *AMLA
        /// </example>
        public static IEnumerable<char> Fkod32Solution1(IEnumerable<char> chars)
        {
            return chars.Reverse().Select(char.ToUpper);
        }

        /// <summary>
        /// Write a program that reads nonnegative integers from standard input. Each line contains exactly one number.
        /// The list represents two sequences of numbers, each of which has at least one element, terminated by the number 0. The input can contain any number.
        /// The program writes to standard output the numbers that are in the second sequence but not in the first!
        /// The program writes the resulting sequence of numbers to the output in the same format.The order of the numbers should be the same as the original order.
        /// Use a linked list to solve this problem!
        /// </summary>
        /// <example>
        /// Input           Output
        /// 5 2 0 
        /// 7 5 0           7 0
        /// 17 2 6 9 0
        /// 2 4 6 8 10 0    4 8 10 0
        /// </example>
        public static IEnumerable<uint> Fkod33Solution1(IEnumerable<uint> firstList, IEnumerable<uint> secondList)
        {
            return secondList.Except(firstList).Add<uint>(0);
        }

        /// <summary>
        /// Write a program that reads words separated by spaces until the end of the line EOF. The words are separated by whitespace characters (space, tab, and newline).
        /// The length of each word is up to 32 characters.The number of lines and words in a line is arbitrary.
        /// The program prints the words one below the other, sorted by their length in ascending order.In case of the same length, the order of arrival counts.
        /// Use a linked list to solve the problem!
        /// </summary>
        /// <param name="rows"></param>
        /// <returns></returns>
        public static IEnumerable<string> Fkod34Solution1(IEnumerable<string> rows)
        {
            return rows.SelectMany(x => x.Split(Array.Empty<char>(), StringSplitOptions.RemoveEmptyEntries)).OrderBy(x => x.Length);
        }

        /// <summary>
        /// Write a program that reads lines from the standard input. The lines contain a grade and a Neptun code separated by a comma.
        /// The number of lines is arbitrary. The program reads until EOF.
        /// Based on the input, a multilist must be created, in which one chain contains the data according to Neptun code, and the other according to arrival in ascending order.
        /// The program lists the data according to Neptun code, then according to grade.
        /// The two lists are separated by a line containing the characters "---". Separate the grades from the Neptun codes with a space character!
        /// Each grade code should be placed on a new line in pairs.
        /// </summary>
        /// <example>
        /// Input       Output
        /// 5,FRTY5F    3 AWSD3E
        /// 3,AWSD3E    2 BDER3W
        /// 2,BDER3W    5 FRTY5F
        /// 4,GRTY6R    4 GRTY6R
        /// 5,QWER3R    5 QWER3R
        ///             ---
        ///             2 BDER3W
        ///             3 AWSD3E
        ///             4 GRTY6R
        ///             5 FRTY5F
        ///             5 QWER3R
        /// </example>
        public static IEnumerable<string> Fkod35Solution1(IEnumerable<string> rows)
        {
            return rows.OrderBy(x => x.Split(',')[1]).Select(x => string.Join(' ', x.Split(','))).Add("---").Concat(rows.OrderBy(y => int.Parse(y.Split(',')[0])).Select(y => string.Join(' ', y.Split(','))));
        }
    }

    
}
