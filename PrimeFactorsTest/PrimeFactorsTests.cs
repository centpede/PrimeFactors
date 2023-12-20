using PrimeFactorsLib;

namespace PrimeFactorsTest
{
    public static class PrimeFactorsTests
    {
        [Fact]
        public static void Test1()
        {
            int testNumber = 993;

            List<int> actual = PrimeFactorsLib.PrimeFactorsLib.PrimeFactors(testNumber);
            List<int> should = new() { 3, 331 };

            Assert.Equal(should, actual);
        }

        [Fact]
        public static void Test2()
        {
            int testNumber = 991;

            List<int> actual = PrimeFactorsLib.PrimeFactorsLib.PrimeFactors(testNumber);
            List<int> should = new();

            Assert.Equal(should, actual);
        }



    }


}
