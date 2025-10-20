using ElectrictClosedDoorPaperSolutions;
using ElectrictClosedDoorPaperSolutionsTest.Helpers;

namespace ElectrictClosedDoorPaperSolutionsTest
{
    [TestClass]
    public class Vzh5SolutionsTests
    {
        private FileHelper fileHelper;

        [TestInitialize]
        public void TestInitializer()
        {
            fileHelper = new FileHelper();
        }

        [DataRow(@"Vzh5\fkod51input1.txt", @"Vzh5\fkod51output1.txt")]
        [DataRow(@"Vzh5\fkod51input2.txt", @"Vzh5\fkod51output2.txt")]
        [TestMethod]
        public async Task TestFkod51Solution1(string inputFilePath, string filePathOfExpectedResult)
        {
            var tempOutputFile = Path.GetTempFileName();
            await Vzh5Solutions.Fkod51Solution1(inputFilePath, tempOutputFile);

            Assert.IsTrue(fileHelper.CompareFiles(filePathOfExpectedResult, tempOutputFile, out int difference), $"Difference: {difference}");
        }

        [DataRow(@"Vzh5\fkod52input1.txt", @"Vzh5\fkod52output1.txt")]
        [TestMethod]
        public void TestFkod52Solution1(string inputFilePath, string filePathOfExpectedResult)
        {
            var tempOutputFile = Path.GetTempFileName();
            Vzh5Solutions.Fkod52Solution1(inputFilePath, tempOutputFile);
            Assert.IsTrue(fileHelper.CompareFiles(filePathOfExpectedResult, tempOutputFile, out int difference), $"Difference: {difference}");
        }

        [DataRow(@"Vzh5\fkod53input1.txt", @"Vzh5\fkod53output1.txt")]
        [TestMethod]
        public void TestFkod53Solution1(string inputFilePath, string filePathOfExpectedResult)
        {
            var tempOutputFile = Path.GetTempFileName();
            Vzh5Solutions.Fkod53Solution1(inputFilePath, tempOutputFile);
            Assert.IsTrue(fileHelper.CompareFiles(filePathOfExpectedResult, tempOutputFile, out int difference), $"Difference: {difference}");
        }

        [DataRow(@"Vzh5\fkod54input1.txt", @"Vzh5\fkod54output1.txt")]
        [TestMethod]
        public void TestFkod54Solution1(string inputFilePath, string filePathOfExpectedResult)
        {
            var tempOutputFile = Path.GetTempFileName();
            Vzh5Solutions.Fkod54Solution1(inputFilePath, tempOutputFile);
            Assert.IsTrue(fileHelper.CompareFiles(filePathOfExpectedResult, tempOutputFile, out int difference), $"Difference: {difference}");
        }

        [DataRow(@"Vzh5\fkod55input1.txt", @"Vzh5\fkod55output1.txt")]
        [TestMethod]
        public void TestFkod55Solution1(string inputFilePath, string filePathOfExpectedResult)
        {
            var tempOutputFile = Path.GetTempFileName();
            Vzh5Solutions.Fkod55Solution1(inputFilePath, tempOutputFile);
            Assert.IsTrue(fileHelper.CompareFiles(filePathOfExpectedResult, tempOutputFile, out int difference), $"Difference: {difference}");
        }
    }
}
