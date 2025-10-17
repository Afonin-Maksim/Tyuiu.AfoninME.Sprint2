using Tyuiu.AfoninME.Sprint2.Task6.V9.Lib;

namespace Tyuiu.AfoninME.Sprint2.Task6.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void Test_RegularDay()
        {
            DataService ds = new DataService();
            string result = ds.FindDateOfNextDay(5, 10);
            Assert.AreEqual("11.05", result);
        }

        [TestMethod]
        public void Test_EndOfMonth_30Days()
        {
            DataService ds = new DataService();
            string result = ds.FindDateOfNextDay(6, 30);
            Assert.AreEqual("01.07", result);
        }

        [TestMethod]
        public void Test_EndOfMonth_31Days()
        {
            DataService ds = new DataService();
            string result = ds.FindDateOfNextDay(7, 31);
            Assert.AreEqual("01.08", result);
        }

        [TestMethod]
        public void Test_EndOfFebruary()
        {
            DataService ds = new DataService();
            string result = ds.FindDateOfNextDay(2, 28);
            Assert.AreEqual("01.03", result);
        }

        [TestMethod]
        public void Test_InvalidDate()
        {
            DataService ds = new DataService();
            string result = ds.FindDateOfNextDay(13, 05);
            Assert.AreEqual("Ошибка: введена некорректная дата.", result);
        }
    }
}
