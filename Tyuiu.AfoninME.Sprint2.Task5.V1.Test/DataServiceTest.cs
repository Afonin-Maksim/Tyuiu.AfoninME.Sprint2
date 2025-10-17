using Tyuiu.AfoninME.Sprint2.Task5.V1.Lib;

namespace Tyuiu.AfoninME.Sprint2.Task5.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void Test_MonthWith31Days()
        {
            DataService ds = new DataService();
            int result = ds.FindMonthDaysCount(1);
            Assert.AreEqual(31, result);
        }

        [TestMethod]
        public void Test_MonthWith30Days()
        {
            DataService ds = new DataService();
            int result = ds.FindMonthDaysCount(6);
            Assert.AreEqual(30, result);
        }

        [TestMethod]
        public void Test_February()
        {
            DataService ds = new DataService();
            int result = ds.FindMonthDaysCount(2);
            Assert.AreEqual(28, result);
        }

        [TestMethod]
        public void Test_InvalidMonth()
        {
            DataService ds = new DataService();
            int result = ds.FindMonthDaysCount(13);
            Assert.AreEqual(0, result);
        }
    }
}
