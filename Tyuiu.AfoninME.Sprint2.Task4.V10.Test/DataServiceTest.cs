using Tyuiu.AfoninME.Sprint2.Task4.V10.Lib;

namespace Tyuiu.AfoninME.Sprint2.Task4.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void Test_WhenConditionTrue()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 10;
            double expected = Math.Round(Math.Pow(1 + (3 / y), x), 3);
            double result = ds.Calculate(x, y);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Test_WhenConditionFalse()
        {
            DataService ds = new DataService();
            double x = 5;
            double y = 2;
            double expected = Math.Round(y + 10 * x - (5 / x), 3);
            double result = ds.Calculate(x, y);
            Assert.AreEqual(expected, result);
        }
    }
}