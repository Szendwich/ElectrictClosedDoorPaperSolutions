using ElectrictClosedDoorPaperSolutions;

namespace ElectrictClosedDoorPaperSolutionsTest
{
    [TestClass]
    public class Vzh2SolutionsTests
    {
        [DataRow("alma korte", 2)]
        [DataRow("szilva,barack", 1)]
        [DataRow("szilva,barack", 1)]
        [DataRow("Hany szo van ebben a mondatban?", 6)]
        [DataRow("", 0)]
        [DataRow("Hany szo van  ebben a   mondatban?", 6)]
        [DataRow("a", 1)]
        [TestMethod]
        public void TestFkod21Solution1(string sentence, int expectedResult)
        {
            Assert.AreEqual(expectedResult, Vzh2Solutions.Fkod21Solution1(sentence));
        }

        [DataRow("alma korte", 2)]
        [DataRow("szilva,barack", 1)]
        [DataRow("szilva,barack", 1)]
        [DataRow("Hany szo van ebben a mondatban?", 6)]
        [DataRow("", 0)]
        [DataRow("Hany szo van  ebben a   mondatban?", 6)]
        [DataRow("a", 1)]
        [TestMethod]
        public void TestFkod21Solution2(string sentence, int expectedResult)
        {
            Assert.AreEqual(expectedResult, Vzh2Solutions.Fkod21Solution2(sentence));
        }

        [DataRow("alma korte", 2)]
        [DataRow("szilva,barack", 1)]
        [DataRow("szilva,barack", 1)]
        [DataRow("Hany szo van ebben a mondatban?", 6)]
        [DataRow("", 0)]
        [DataRow("Hany szo van  ebben a   mondatban?", 6)]
        [DataRow("a", 1)]
        [TestMethod]
        public void TestFkod21Solution3(string sentence, int expectedResult)
        {
            Assert.AreEqual(expectedResult, Vzh2Solutions.Fkod21Solution3(sentence));
        }

        [DataRow("indul a görög aludni.", "yes")]
        [DataRow("géza, kék az ég!", "yes")]
        [DataRow("nehéz ez a feladat", "no")]
        [DataRow("rám német nem lel, elmentem én már.", "yes")]
        [TestMethod]
        public void TestFkod22Solution1(string sentence, string expectedResult)
        {
            Assert.AreEqual(expectedResult, Vzh2Solutions.Fkod22Solution1(sentence));
        }

        [DataRow("indul a görög aludni", "indula görög a ludni")]
        [DataRow("fordítva", "avtídrof")]
        [TestMethod]
        public void TestFkod23Solution1(string sentence, string expectedResult)
        {
            Assert.AreEqual(expectedResult, Vzh2Solutions.Fkod23Solution1(sentence));
        }

        [DataRow("indul a görög aludni", "indula görög a ludni")]
        [DataRow("fordítva", "avtídrof")]
        [TestMethod]
        public void TestFkod23Solution2(string sentence, string expectedResult)
        {
            Assert.AreEqual(expectedResult, Vzh2Solutions.Fkod23Solution2(sentence));
        }

        [DataRow("abababa", "ababa", "yes")]
        [DataRow("pompom", "pom", "yes")]
        [DataRow("alma", "alma", "yes")]
        [DataRow("alma", "a", "yes")]
        [DataRow("kerek", "ke", "no")]
        [TestMethod]
        public void TestFkod24Solution1(string word, string border, string expectedResult)
        {
            Assert.AreEqual(expectedResult, Vzh2Solutions.Fkod24Solution1(word, border));
        }

        [DataRow("abababa", "ababa", "yes")]
        [DataRow("pompom", "pom", "yes")]
        [DataRow("alma", "alma", "yes")]
        [DataRow("alma", "a", "yes")]
        [DataRow("kerek", "ke", "no")]
        [TestMethod]
        public void TestFkod24Solution2(string word, string border, string expectedResult)
        {
            Assert.AreEqual(expectedResult, Vzh2Solutions.Fkod24Solution2(word, border));
        }

        [DataRow("Ez egy pelDaMONdat.", "eZ EGY PELdAmonDAT.")]
        [TestMethod]
        public void TestFkod25Solution1(string sentence, string expectedResult)
        {
            Assert.AreEqual(expectedResult, Vzh2Solutions.Fkod25Solution1(sentence));
        }

        [DataRow("almafa", "alma", 0)]
        [DataRow("JuhászPici", "ász", 3)]
        [DataRow("szakest", "pia", -1)]
        [DataRow("nap", "nappal", -1)]
        [TestMethod]
        public void TestKod26Solution1(string firstWord, string secondWord, int expectedResult) 
        {
            Assert.AreEqual(expectedResult, Vzh2Solutions.Fkod26Solution1(firstWord, secondWord));
        }

        [DataRow("almafa", "alma", 0)]
        [DataRow("JuhászPici", "ász", 3)]
        [DataRow("szakest", "pia", -1)]
        [DataRow("nap", "nappal", -1)]
        [TestMethod]
        public void TestKod26Solution2(string firstWord, string secondWord, int expectedResult)
        {
            Assert.AreEqual(expectedResult, Vzh2Solutions.Fkod26Solution2(firstWord, secondWord));
        }
    }
}
