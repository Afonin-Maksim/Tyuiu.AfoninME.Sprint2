using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.AfoninME.Sprint2.Task2.V29.Lib;

namespace Tyuiu.AfoninME.Sprint2.Task2.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckInArea_PointInside()
        {
            DataService ds = new DataService();
            bool result = ds.CheckDotInShadedArea(6, 4);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CheckOutOfArea_PointOutside()
        {
            DataService ds = new DataService();
            bool result = ds.CheckDotInShadedArea(14, 10);
            Assert.IsFalse(result);
        }
    }
}