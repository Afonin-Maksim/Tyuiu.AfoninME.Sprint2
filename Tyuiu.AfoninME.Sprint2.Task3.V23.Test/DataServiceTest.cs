using Tyuiu.AfoninME.Sprint2.Task3.V23.Lib;

namespace Tyuiu.AfoninME.Sprint2.Task3.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void Test_XGreaterThanOne()
        {
            DataService ds = new DataService();
            double result = ds.Calculate(2);
            double expected = Math.Round(2 * Math.Pow((2 + 1) / (2 - 1), 2), 3);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Test_XEqualsZero()
        {
            DataService ds = new DataService();
            double result = ds.Calculate(0);
            double expected = Math.Round(Math.Pow(0, 2) + Math.Cos(Math.Pow(0, 2)) - 17, 3);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Test_XBetweenMinus27AndTwo()
        {
            DataService ds = new DataService();
            double result = ds.Calculate(-5);
            double expected = Math.Round(Math.Pow(-5, 2) - Math.Sin(Math.Pow(-5, 2)) + 3, 3);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Test_XLessOrEqualMinus27()
        {
            DataService ds = new DataService();
            double result = ds.Calculate(-30);
            double expected = Math.Round(-30 + 10 * (-30) - (1 / Math.Pow(-30, 2)), 3);
            Assert.AreEqual(expected, result);
        }
    }
}