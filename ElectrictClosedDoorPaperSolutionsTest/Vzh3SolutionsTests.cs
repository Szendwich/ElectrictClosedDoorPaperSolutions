using ElectrictClosedDoorPaperSolutions;

namespace ElectrictClosedDoorPaperSolutionsTest
{
    [TestClass]
    public class Vzh3SolutionsTests
    {
        [DynamicData(nameof(GetFkod31TestData1), DynamicDataSourceType.Method)]
        [DynamicData(nameof(GetFkod31TestData2), DynamicDataSourceType.Method)]
        [DataTestMethod]
        public void TestFkod312Solution1(IEnumerable<double> numbers, double expectedResult)
        {
            Assert.AreEqual(expectedResult, Vzh3Solutions.Fkod31Solution1(numbers));
        }

        private static IEnumerable<object[]> GetFkod31TestData1() 
        {
            yield return new object[] { new List<double>() { 3.6, 1.2, 5, 1.48 }, 2.68 };
        }

        private static IEnumerable<object[]> GetFkod31TestData2()
        {
            yield return new object[] { new List<double>() { -5.4, 3.2, -524.36, -0, -200 }, -724.36 };
        }

        [DynamicData(nameof(GetFkod32TestData1), DynamicDataSourceType.Method)]
        [DynamicData(nameof(GetFkod32TestData2), DynamicDataSourceType.Method)]
        [DynamicData(nameof(GetFkod32TestData3), DynamicDataSourceType.Method)]
        [DataTestMethod]
        public void TestFkod32Solutions1(IEnumerable<char> letters, IEnumerable<char> expectedResult)
        {
            Assert.IsTrue(expectedResult.SequenceEqual(Vzh3Solutions.Fkod32Solution1(letters)));
        }

        private static IEnumerable<object[]> GetFkod32TestData1()
        {
            yield return new object[] { new List<char>() { '*' }, new List<char> { '*' } };
        }

        private static IEnumerable<object[]> GetFkod32TestData2()
        {
            yield return new object[] { new List<char>() { 'g', '*' }, new List<char>() { '*', 'G' } };
        }

        private static IEnumerable<object[]> GetFkod32TestData3()
        {
            yield return new object[] { new List<char>() {'a', 'l', 'M', 'a', '*' }, new List<char>() { '*', 'A', 'M', 'L', 'A' } };
        }

        [DynamicData(nameof(GetFkod33TestData1), DynamicDataSourceType.Method)]
        [DynamicData(nameof(GetFkod33TestData2), DynamicDataSourceType.Method)]
        [DataTestMethod]
        public void TestFkod33Solutions1(IEnumerable<uint> firstList, IEnumerable<uint> secondList, IEnumerable<uint> expectedResult)
        {
            Assert.IsTrue(expectedResult.SequenceEqual(Vzh3Solutions.Fkod33Solution1(firstList, secondList)));
        }

        private static IEnumerable<object[]> GetFkod33TestData1()
        {
            yield return new object[] { new List<uint>() { 5, 2, 0 }, new List<uint> { 7, 5, 0 }, new List<uint> { 7, 0 } };
        }

        private static IEnumerable<object[]> GetFkod33TestData2()
        {
            yield return new object[] { new List<uint>() { 17, 2, 6, 9, 0 }, new List<uint>() { 2, 4, 6, 8, 10, 0 }, new List<uint>() { 4, 8, 10, 0 } };
        }

        [DynamicData(nameof(GetFkod34TestData1), DynamicDataSourceType.Method)]
        [DynamicData(nameof(GetFkod34TestData2), DynamicDataSourceType.Method)]
        [DataTestMethod]
        public void TestFkod34Solutions1(IEnumerable<string> rows, IEnumerable<string> expectedResult)
        {
            Assert.IsTrue(expectedResult.SequenceEqual(Vzh3Solutions.Fkod34Solution1(rows)));
        }

        private static IEnumerable<object[]> GetFkod34TestData1()
        {
            yield return new object[] { new List<string>() { "data work product", "area program system work" }, new List<string> { "data", "work", "area", "work", "system", "product", "program" } };
        }

        private static IEnumerable<object[]> GetFkod34TestData2()
        {
            yield return new object[] { new List<string>() { "kis kacsa furdik fekete toban" }, new List<string>() { "kis", "kacsa", "toban", "furdik", "fekete" } };
        }

        [DynamicData(nameof(GetFkod35TestData1), DynamicDataSourceType.Method)]
        [DataTestMethod]
        public void TestFkod35Solutions1(IEnumerable<string> rows, IEnumerable<string> expectedResult)
        {
            Assert.IsTrue(expectedResult.SequenceEqual(Vzh3Solutions.Fkod35Solution1(rows)));
        }

        private static IEnumerable<object[]> GetFkod35TestData1()
        {
            yield return new object[] { new List<string>() { "5,FRTY5F", "3,AWSD3E", "2,BDER3W", "4,GRTY6R", "5,QWER3R" },
                                        new List<string> { "3 AWSD3E", "2 BDER3W", "5 FRTY5F", "4 GRTY6R", "5 QWER3R", "---", "2 BDER3W", "3 AWSD3E", "4 GRTY6R", "5 FRTY5F", "5 QWER3R" } };
        }
    }
}
