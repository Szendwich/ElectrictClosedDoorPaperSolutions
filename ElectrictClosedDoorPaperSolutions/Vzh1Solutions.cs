using System.Text;

namespace ElectrictClosedDoorPaperSolutions
{
    public class Vzh1Solutions
    {
        #region Public Methods

        /// <summary>
        /// Write a program that reads two positive integers separated by a comma and prints the word "yes" or "no" to the screen depending on whether the numbers are relatively prime.
        /// (Two or more numbers are called relatively prime if their greatest common divisor is 1.)
        /// </summary>
        /// <example>
        /// Input     Output
        /// 12,121      yes 
        /// 16,72       no
        /// 26,49       yes
        /// </example>
        public static string Fkod11Solution1(int firstNumber, int secondNumber)
        {
            return firstNumber != 0
                   && secondNumber != 0
                   && ((firstNumber % 2 != 0 && secondNumber % 2 == 0)
                    || (firstNumber % 2 == 0 && secondNumber % 2 != 0)) ? "yes" : "no";
        }

        /// <summary>
        /// Write a program that reads two positive integers separated by a comma and prints the word "yes" or "no" to the screen depending on whether the numbers are relatively prime.
        /// (Two or more numbers are called relatively prime if their greatest common divisor is 1.)
        /// </summary>
        /// <example>
        /// Input     Output
        /// 12,121      yes 
        /// 16,72       no
        /// 26,49       yes
        /// </example>
        public static string Fkod11Solution2(int firstNumber, int secondNumber)
        {
            return firstNumber != 0
                   && secondNumber != 0
                   && GreatestCommonDivisor(firstNumber, secondNumber) == 1 ? "yes" : "no";
        }

        /// <summary>
        /// Write a program that reads two positive integers (n, k) and prints the number of combinations of n based on k without repetition (where n is k).
        /// Assume that n and k are between 0 and 10.
        /// </summary>
        /// <example>
        /// Input       Output
        /// 6,4         15
        /// 9,3         84
        /// </example>
        public static int Fkod12Solution1(int n, int k)
        {
            return CalculateFactorial(n) / (CalculateFactorial(k) * CalculateFactorial(n - k));
        }

        /// <summary>
        /// Write a program that reads an integer between 0 and 100 and prints its text form on the screen without accents.
        /// Hungarian language!!!
        /// </summary>
        /// <example>
        /// Input       Output
        /// 1           egy
        /// 42          negyvenketto
        /// </example>
        public static string Fkod13Solution1(int number)
        {
            StringBuilder returnValue = new();
            if (number != 0)
            {
                if (number > 0 && number < 10)
                {
                    returnValue.Append(ConvertNumberToHungarian(number));
                }
                else
                {
                    int firstWord = number / 10;
                    int secondWord = number % 10;

                    if (secondWord == 0)
                    {
                        returnValue.Append(ConvertTenNumberToHungarian(firstWord, true));
                    }
                    else
                    {
                        returnValue.Append(ConvertTenNumberToHungarian(firstWord, false));
                        returnValue.Append(ConvertNumberToHungarian(secondWord));
                    }
                }
            }
            else
            {
                returnValue.Append("nulla");
            }

            return returnValue.ToString();
        }

        /// <summary>
        /// Write a program that reads an integer between 0 and 100 and prints its text form on the screen without accents.
        /// Hungarian language!!!
        /// </summary>
        /// <example>
        /// Input       Output
        /// 1           egy
        /// 42          negyvenketto
        /// </example>
        public static string Fkod13Solution2(int number)
        {
            StringBuilder stringBuilder = new();

            if (number != 0)
            {
                if (number >= 10)
                {
                    int ten = number / 10;
                    number -= ten * 10;
                    if ((number % 10) != 0)
                    {
                        stringBuilder.Append(ConvertTenNumberToHungarian(ten, false));
                    }
                    else
                    {
                        stringBuilder.Append(ConvertTenNumberToHungarian(ten, true));
                    }
                }
                stringBuilder.Append(ConvertNumberToHungarian(number));
            }
            else
            {
                stringBuilder.Append("nulla");
            }

            return stringBuilder.ToString();
        }

        /// <summary>
        /// Write a program that reads a positive integer and prints its distance from the nearest square number!
        /// (The distance between two numbers is the absolute value of their difference.)
        /// </summary>
        /// <example>
        /// Input       Output
        /// 45          4
        /// </example>
        public static int Fkod14Solution1(long number)
        {
            var lookup = new Dictionary<int, long>();
            for (int i = 0; i < 20000; i++)
            {
                lookup[i] = i * i;
            }

            var index = new List<long>([.. lookup.Values]);
            index.Sort();

            var foundIndex = index.BinarySearch(number);
            return foundIndex < 0 ? (int)Math.Abs(number - lookup[~foundIndex]) : (int)(number - lookup[foundIndex]);
        }

        /// <summary>
        /// Write a program that reads a positive integer and prints its distance from the nearest square number!
        /// (The distance between two numbers is the absolute value of their difference.)
        /// </summary>
        /// <example>
        /// Input       Output
        /// 45          4
        /// </example>
        public static int Fkod14Solution2(long number)
        {
            long previous = number, difference, i = 0;

            do
            {
                i++;
                difference = (long)Math.Abs(number - Math.Pow(i, 2));
                if (difference < previous)
                {
                    previous = difference;
                }
            } while (i <= Math.Sqrt(number));

            return (int)previous;

        }

        /// <summary>
        /// Write a program that reads five pairs of numbers (ten integers separated by commas).
        /// The pairs of numbers represent the start and end points of intervals.The program prints the length of the longest interval!
        /// (It can be assumed that the first member of the pairs of numbers is less than the second.)
        /// </summary>
        /// <example>
        /// Input                               Output
        /// -12,-2,34,56,4,100,65,83,-45,23     96
        /// </example>
        public static int Fkod15Solution1(int[] pairsOfNumbers)
        {
            int biggestInterval = int.MinValue;

            int i = 0;
            while (i < 5)
            {
                var _ = Math.Abs(pairsOfNumbers[i + 1] - pairsOfNumbers[i++]);
                if (_ > biggestInterval)
                {
                    biggestInterval = _;
                }
            }

            return biggestInterval;
        }

        /// <summary>
        /// Write a program that reads five pairs of numbers (ten integers separated by commas).
        /// The pairs of numbers represent the start and end points of intervals.The program prints the length of the longest interval!
        /// (It can be assumed that the first member of the pairs of numbers is less than the second.)
        /// </summary>
        /// <example>
        /// Input                               Output
        /// -12,-2,34,56,4,100,65,83,-45,23     96
        /// </example>
        public static int Fkod15Solution2(int[] tomb)
        {
            int i = 2, biggestInterval, temp;
            biggestInterval = tomb[1] - tomb[0];

            while (i < 9)
            {
                temp = tomb[i + 1] - tomb[i];
                if (temp > biggestInterval)
                {
                    biggestInterval = temp;
                }

                i += 2;
            }

            return biggestInterval;
        }

        /// <summary>
        /// Írj programot, amely beolvas három egész számpárt (hat, vesszõvel elválasztott egész számot).
        /// A program írja ki az intervallumok legtágabb közös részintervallumának hosszát!
        /// (Feltételezhetõ, hogy a számpárok elsõ tagja kisebb a másodiknál.)<br>
        /// </summary>
        /// <example>
        /// Input           Output
        /// 1,5,3,10,0,2    0
		/// -5,2,-3,1,-7,0  3
        /// </example>
        public static int Fkod16Solution1(int[] pairsOfNumbers)
        {
            int intervalLeft = SearchIntervalBeginEnd(pairsOfNumbers, true);
            int intervalRight = SearchIntervalBeginEnd(pairsOfNumbers, false);

            return intervalLeft < intervalRight ? Math.Abs(intervalRight - intervalLeft) : 0;
        }

        /// <summary>
        /// Írj programot, amely beolvas három egész számpárt (hat, vesszõvel elválasztott egész számot).
        /// A program írja ki az intervallumok legtágabb közös részintervallumának hosszát!
        /// (Feltételezhetõ, hogy a számpárok elsõ tagja kisebb a másodiknál.)<br>
        /// </summary>
        /// <example>
        /// Input           Output
        /// 1,5,3,10,0,2    0
		/// -5,2,-3,1,-7,0  3
        /// </example>
        public static int Fkod16Solution2(int[] pairsOfNumbers)
        {
            int left = pairsOfNumbers[0];
            int right = pairsOfNumbers[1];
            if (left < pairsOfNumbers[2])
                left = pairsOfNumbers[2];
            if (right > pairsOfNumbers[3])
                right = pairsOfNumbers[3];
            if (left < pairsOfNumbers[4])
                left = pairsOfNumbers[4];
            if (right > pairsOfNumbers[5])
                right = pairsOfNumbers[5];

            return right > left ? Math.Abs(left - right) : 0;
        }

        /// <summary>
        /// Írj programot, amely beolvas egy egész számot (n), és kiírja a 0 és n közötti köbszámok számát!
        /// (Köbszám az, aminek köbgyöke egész.)
        /// </summary>
        /// <example>
        /// Input       Output
        ///  0           1
        ///  9           3
        /// -10          3
        /// 1024        11
        /// </example>
        public static int Fkod17Solution1(int number)
        {
            var lookup = new List<int>();
            for (int i = 0; i < 10000; i++)
            {
                if (CubeRoot(i))
                {
                    lookup.Add(i);
                }
            }

            int n = 0;
            var absNumber = Math.Abs(number);
            while (lookup[n] <= absNumber) { ++n; }

            return n;
        }

        /// <summary>
        /// Írj programot, amely beolvas egy egész számot (n), és kiírja a 0 és n közötti köbszámok számát!
        /// (Köbszám az, aminek köbgyöke egész.)
        /// </summary>
        /// <example>
        /// Input       Output
        ///  0           1
        ///  9           3
        /// -10          3
        /// 1024        11
        /// </example>
        public static int Fkod17Solution2(int number)
        {
            int i;
            for (i = 0; Math.Pow(i, 3) <= Math.Abs(number); i++) ;
            return i;
        }

        #endregion Public Methods

        #region Private Methods

        private static int GreatestCommonDivisor(int firstNumber, int secondNumber)
        {
            int n = 0;
            while (firstNumber % secondNumber != 0)
            {
                n = firstNumber % secondNumber;
                firstNumber = secondNumber;
                secondNumber = n;
            }

            return secondNumber;
        }

        private static string ConvertNumberToHungarian(int number)
        {
            return number switch
            {
                1 => "egy",
                2 => "ketto",
                3 => "harom",
                4 => "negy",
                5 => "ot",
                6 => "hat",
                7 => "het",
                8 => "nyolc",
                9 => "kilenc",
                _ => string.Empty,
            };
        }

        private static string ConvertTenNumberToHungarian(int number, bool valami)
        {
            return number switch
            {
                1 => valami ? "tiz" : "tizen",
                2 => valami ? "husz" : "huszon",
                3 => "harminc",
                4 => "negyven",
                5 => "otven",
                6 => "hatvan",
                7 => "hetven",
                8 => "nyolcvan",
                9 => "kilencven",
                _ => string.Empty,
            };
        }

        private static int CalculateFactorial(int n)
        {
            int factorial = 1;
            for (int i = n; i > 0; i--)
            {
                factorial *= i;
            }
            return factorial;
        }

        private static int SearchIntervalBeginEnd(int[] pairsOfNumbers, bool beginOrEnd)
        {
            int intervalEdge = pairsOfNumbers[beginOrEnd ? 0 : 1];

            for (int i = beginOrEnd ? 2 : 3; i <= pairsOfNumbers.Length - (beginOrEnd ? 2 : 1); i = i + 2)
            {
                if (beginOrEnd ? intervalEdge < pairsOfNumbers[i] : intervalEdge > pairsOfNumbers[i])
                {
                    intervalEdge = pairsOfNumbers[i];
                }
            }

            return intervalEdge;
        }

        private static bool CubeRoot(int n)
        {
            double i, precision = 0.000001;

            for (i = 1; (i * i * i) <= n; ++i) ;

            for (--i; (i * i * i) < n; i += precision) ;

            return Math.Abs(i % 1) <= double.Epsilon * 100.0;
        }

        #endregion Private Methods
    }
}
