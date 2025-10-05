using System.Text;

namespace ElectrictClosedDoorPaperSolutions
{
    public class Vzh2Solutions
    {
        /// <summary>
        /// Write a program that reads a line and prints out how many words are in the line! We consider a single space as the only delimiter. It can be assumed that the line consists of at most 64 characters.
        /// </summary>
        /// <example>
        /// Input                          Output
        /// alma korte                          2
        /// szilva,barack                       1
        /// Hany szo van ebben a mondatban?     6
        /// </example>
        public static int Fkod21Solution1(string sentence)
        {
            return string.IsNullOrWhiteSpace(sentence) ? 0 : sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
        }

        /// <summary>
        /// Write a program that reads a line and prints out how many words are in the line! We consider a single space as the only delimiter. It can be assumed that the line consists of at most 64 characters.
        /// </summary>
        /// <example>
        /// Input                          Output
        /// alma korte                          2
        /// szilva,barack                       1
        /// Hany szo van ebben a mondatban?     6
        /// </example>
        public static int Fkod21Solution2(string sentence)
        {
            if (string.IsNullOrWhiteSpace(sentence))
            {
                return 0;
            }
            char[] sentenceCharArray = sentence.ToCharArray();
            int words = 0;

            if (sentenceCharArray.Length == 1)
            {
                return 1;
            }

            for (int i = 1; i < sentenceCharArray.Length; i++)
            {
                if (sentenceCharArray[i - 1] == ' ' && char.IsLetter(sentenceCharArray[i])) 
                {
                    ++words;
                }
            }
            ++words;

            return words;
        }

        /// <summary>
        /// Write a program that reads a line and prints out how many words are in the line! We consider a single space as the only delimiter. It can be assumed that the line consists of at most 64 characters.
        /// </summary>
        /// <example>
        /// Input                          Output
        /// alma korte                          2
        /// szilva,barack                       1
        /// Hany szo van ebben a mondatban?     6
        /// </example>
        public static int Fkod21Solution3(string sentence)
        {
            if (string.IsNullOrWhiteSpace(sentence))
            {
                return 0;
            }
            char[] sentenceCharArray = sentence.ToCharArray();
            int words = 0;
            bool where = true;

            for (int i = 0; i < sentenceCharArray.Length; i++)
            {
                if (where && !char.IsWhiteSpace(sentenceCharArray[i]))
                {
                    where = false;
                    ++words;
                }
                if (char.IsWhiteSpace(sentenceCharArray[i]) && !where)
                {
                    where = true;
                }
            }

            return words;
        }

        /// <summary>
        /// Write a program that reads a line and determines whether it is a palindrome. Palindromes are phrases or sentences that have the same meaning when read backwards.
        /// The program ignores non-letter characters(spaces, commas, etc.)! It is assumed that the input consists of only lowercase letters.
        /// The program returns the word "yes" or "no" as the answer! It is assumed that the line consists of a maximum of 64 characters.
        /// </summary>
        /// Input
        /// indul a görög aludni.                   igen
        /// géza, kék az ég!                        igen
        /// nehéz ez a feladat                      nem
        /// rám német nem lel, elmentem én már.     igen
        /// <example>
        /// </example>
        public static string Fkod22Solution1(string sentence)
        {
            var sentenceOnlyWithLetters = new string(sentence.Where(c => char.IsLetter(c)).ToArray());
            int i = 0;
            for(; i < sentenceOnlyWithLetters.Length / 2; i++)
            {
                if (sentenceOnlyWithLetters[i] != sentenceOnlyWithLetters[sentenceOnlyWithLetters.Length - 1 - i])
                {
                    break;
                }
            }

            return i < sentenceOnlyWithLetters.Length / 2 ? "no" : "yes";
        }

        /// <summary>
        /// Write a program that reads a line and prints its reverse! It is assumed that the line consists of at most 64 characters.
        /// </summary>
        /// <example>
        /// Input                   Output
        /// indul a görög aludni    indula görög aludni
        /// fordítva                avtídrof
        /// </example>
        public static string Fkod23Solution1(string sentence)
        {
            if (string.IsNullOrWhiteSpace(sentence))
            {
                return string.Empty;
            }

            return new string([.. sentence.Reverse()]);
        }

        /// <summary>
        /// Write a program that reads a line and prints its reverse! It is assumed that the line consists of at most 64 characters.
        /// </summary>
        /// <example>
        /// Input                   Output
        /// indul a görög aludni    indula görög aludni
        /// fordítva                avtídrof
        /// </example>
        public static string Fkod23Solution2(string sentence)
        {
            if (string.IsNullOrWhiteSpace(sentence))
            {
                return string.Empty;
            }

            StringBuilder stringBuilder = new();
            for (int i = sentence.Length - 1; i >= 0; i--)
            {
                stringBuilder.Append(sentence[i]);
            }

            return stringBuilder.ToString();
        }

        /// <summary>
        /// Write a program that reads a line containing two words separated by a single space and determines whether the second word is a border of the first.
        /// A word is a border of another if it is both the beginning and end of it.It is assumed that the line consists of at most 64 characters.
        /// <example>
        /// Input           Output
        /// abababa ababa   yes
        /// pompom pom      yes
        /// alma alma       yes
        /// alma a          yes
        /// kerek ke        no
        /// </example>
        public static string Fkod24Solution1(string word, string border)
        {
            return word.StartsWith(border) && word.EndsWith(border) ? "yes" : "no";
        }

        /// <summary>
        /// Write a program that reads a line containing two words separated by a single space and determines whether the second word is a border of the first.
        /// A word is a border of another if it is both the beginning and end of it.It is assumed that the line consists of at most 64 characters.
        /// </summary>
        /// <example>
        /// Input           Output
        /// abababa ababa   yes
        /// pompom pom      yes
        /// alma alma       yes
        /// alma a          yes
        /// kerek ke        no
        /// </example>
        public static string Fkod24Solution2(string word, string border)
        {
            if(word.Length < border.Length)
            {
                return "no";
            }
            int i = 0;
            while (i < border.Length)
            {
                if (word[i] != border[i] || word[word.Length - i - 1] != border[border.Length - i - 1])
                {
                    break;
                }
                ++i;
            }
            return i == border.Length ? "yes" : "no";
        }

        /// <summary>
        /// Write a program that reads a line and converts it to the screen in a format that changes all lowercase letters to uppercase and all uppercase letters to lowercase.
        /// It is assumed that the lines contain only letters of the English alphabet, punctuation marks, and spaces.It is assumed that the line consists of at most 64 characters.
        /// </summary>
        /// <example>
        /// Input                   Output
        /// Ez egy pelDaMONdat.     eZ EGY PELdAmonDAT.
        /// </example>
        public static string Fkod25Solution1(string sentence)
        {
            char[] chars = new char[sentence.Length];
            for (int i = 0; i < sentence.Length; i++)
            {
                chars[i] = char.IsLower(sentence[i]) ? char.ToUpper(sentence[i]) : char.ToLower(sentence[i]);
            }

            return new string(chars);
        }

        /// <summary>
        /// Write a program that reads a line containing two words separated by a single space and searches the first word for the starting position of the first occurrence of the second word.
        /// The program should print -1 if the searched word is not found, otherwise the starting position.
        /// It is assumed that the line consists of at most 64 characters.
        /// </summary>
        /// <example>
        /// Input               Output
        /// almafa alma         0
        /// JuhászPici ász      3
        /// szakest pia         -1
        /// nap nappal          -1
        /// </example>
        public static int Fkod26Solution1(string firstWord, string secondWord)
        {
            return firstWord.IndexOf(secondWord);
        }

        /// <summary>
        /// Write a program that reads a line containing two words separated by a single space and searches the first word for the starting position of the first occurrence of the second word.
        /// The program should print -1 if the searched word is not found, otherwise the starting position.
        /// It is assumed that the line consists of at most 64 characters.
        /// </summary>
        /// <example>
        /// Input               Output
        /// almafa alma         0
        /// JuhászPici ász      3
        /// szakest pia         -1
        /// nap nappal          -1
        /// </example>
        public static int Fkod26Solution2(string firstWord, string secondWord)
        {
            if (firstWord.Length < secondWord.Length)
            {
                return -1;
            }

            for (int i = 0; i < firstWord.Length - secondWord.Length; i++)
            {
                if (firstWord[i] == secondWord[0])
                {
                    int j = 1;
                    for (; j < secondWord.Length; j++) 
                    {
                        if (firstWord[i + j] != secondWord[j])
                        {
                            break;
                        }
                    }

                    if (j == secondWord.Length)
                    {
                        return i;
                    }
                }
            }

            return -1;
        }
    }
}
