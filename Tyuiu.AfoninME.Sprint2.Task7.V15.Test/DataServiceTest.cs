using Tyuiu.AfoninME.Sprint2.Task7.V15.Lib;

namespace Tyuiu.AfoninME.Sprint2.Task7.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void Test_PointInside()
        {
            DataService ds = new DataService();
            bool result = ds.CheckDotInShadedArea(1, 1);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Test_PointOutsideBelow()
        {
            DataService ds = new DataService();
            bool result = ds.CheckDotInShadedArea(0.5, -0.5);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Test_PointOnInnerCircle()
        {
            DataService ds = new DataService();
            bool result = ds.CheckDotInShadedArea(1, 0);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Test_PointOnOuterCircle()
        {
            DataService ds = new DataService();
            bool result = ds.CheckDotInShadedArea(0, 2);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Test_PointOutsideOuterCircle()
        {
            DataService ds = new DataService();
            bool result = ds.CheckDotInShadedArea(2.1, 0.1);
            Assert.IsFalse(result);
        }
    }
}