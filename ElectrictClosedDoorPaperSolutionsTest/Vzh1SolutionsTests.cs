using ElectrictClosedDoorPaperSolutions;

namespace ElectrictClosedDoorPaperSolutionsTest
{
    [TestClass]
    public sealed class Vzh1SolutionsTests
    {
        [DataRow(12, 121, "yes")]
        [DataRow(16, 72, "no")]
        [DataRow(26, 49, "yes")]
        [DataRow(0, 1, "no")]
        [TestMethod]
        public void TestFkod11Solution1(int firstNumber, int secondNumber, string expectedResult)
        {
            Assert.AreEqual(expectedResult, Vzh1Solutions.Fkod11Solution1(firstNumber, secondNumber));
        }

        [DataRow(12, 121, "yes")]
        [DataRow(16, 72, "no")]
        [DataRow(26, 49, "yes")]
        [DataRow(0, 1, "no")]
        [TestMethod]
        public void TestFkod11Solution2(int firstNumber, int secondNumber, string expectedResult)
        {
            Assert.AreEqual(expectedResult, Vzh1Solutions.Fkod11Solution2(firstNumber, secondNumber));
        }

        [DataRow(6, 4, 15)]
        [DataRow(9, 3, 84)]
        [TestMethod]
        public void TestFkod12Solution1(int n, int k, int expectedResult)
        {
            Assert.AreEqual(expectedResult, Vzh1Solutions.Fkod12Solution1(n, k));
        }

        [DataRow(1, "egy")]
        [DataRow(42, "negyvenketto")]
        [DataRow(0, "nulla")]
        [DataRow(10, "tiz")]
        [DataRow(19, "tizenkilenc")]
        [DataRow(20, "husz")]
        [DataRow(21, "huszonegy")]
        [TestMethod]
        public void TestFkod13Solution1(int number, string expectedResult)
        {
            Assert.AreEqual(expectedResult, Vzh1Solutions.Fkod13Solution1(number));
        }

        [DataRow(1, "egy")]
        [DataRow(42, "negyvenketto")]
        [DataRow(0, "nulla")]
        [DataRow(10, "tiz")]
        [DataRow(19, "tizenkilenc")]
        [DataRow(20, "husz")]
        [DataRow(21, "huszonegy")]
        [TestMethod]
        public void TestFkod13Solution2(int number, string expectedResult)
        {
            Assert.AreEqual(expectedResult, Vzh1Solutions.Fkod13Solution2(number));
        }

        [DataRow(45, 4)]
        [DataRow(0, 0)]
        [DataRow(100, 0)]
        [TestMethod]
        public void TestFkod14Solution1(long number, int expectedResult)
        {
            Assert.AreEqual(expectedResult, Vzh1Solutions.Fkod14Solution1(number));
        }

        [DataRow(45, 4)]
        [DataRow(0, 0)]
        [DataRow(100, 0)]
        [TestMethod]
        public void TestFkod14Solution2(long number, int expectedResult)
        {
            Assert.AreEqual(expectedResult, Vzh1Solutions.Fkod14Solution2(number));
        }


        [DataRow(new int[] { -12, -2, 34, 56, 4, 100, 65, 83, -45, 23 }, 96)]
        [TestMethod]
        public void TestFkod15Solution1(int[] pairsOfNumbers, int expectedResult)
        {
            Assert.AreEqual(expectedResult, Vzh1Solutions.Fkod15Solution1(pairsOfNumbers));
        }

        [DataRow(new int[] { -12, -2, 34, 56, 4, 100, 65, 83, -45, 23 }, 96)]
        [TestMethod]
        public void TestFkod15Solution2(int[] pairsOfNumbers, int expectedResult)
        {
            Assert.AreEqual(expectedResult, Vzh1Solutions.Fkod15Solution2(pairsOfNumbers));
        }

        [DataRow(new int[] { 1, 5, 3, 10, 0, 2 }, 0)]
        [DataRow(new int[] { -5, 2, -3, 1, -7, 0 }, 3)]
        [DataRow(new int[] { -5, 2, -5, 2, -7, 0 }, 5)]
        [DataRow(new int[] { -5, 2, -5, 2, -5, 2 }, 7)]
        [DataRow(new int[] { 0, 0, 0, 0, 0, 0 }, 0)]
        [TestMethod]
        public void TestFkod16Solution1(int[] pairsOfNumbers, int expectedResult)
        {
            Assert.AreEqual(expectedResult, Vzh1Solutions.Fkod16Solution1(pairsOfNumbers));
        }

        [DataRow(new int[] { 1, 5, 3, 10, 0, 2 }, 0)]
        [DataRow(new int[] { -5, 2, -3, 1, -7, 0 }, 3)]
        [DataRow(new int[] { -5, 2, -5, 2, -7, 0 }, 5)]
        [DataRow(new int[] { -5, 2, -5, 2, -5, 2 }, 7)]
        [DataRow(new int[] { 0, 0, 0, 0, 0, 0 }, 0)]
        [TestMethod]
        public void TestFkod16Solution2(int[] pairsOfNumbers, int expectedResult)
        {
            Assert.AreEqual(expectedResult, Vzh1Solutions.Fkod16Solution2(pairsOfNumbers));
        }

        [DataRow(0, 1)]
        [DataRow(9, 3)]
        [DataRow(-10, 3)]
        [DataRow(1024, 11)]
        [TestMethod]
        public void TestFkod17Solution1(int number, int expectedResult)
        {
            Assert.AreEqual(expectedResult, Vzh1Solutions.Fkod17Solution1(number));
        }

        [DataRow(0, 1)]
        [DataRow(9, 3)]
        [DataRow(-10, 3)]
        [DataRow(1024, 11)]
        [TestMethod]
        public void TestFkod17Solution2(int number, int expectedResult)
        {
            Assert.AreEqual(expectedResult, Vzh1Solutions.Fkod17Solution2(number));
        }
    }
}
