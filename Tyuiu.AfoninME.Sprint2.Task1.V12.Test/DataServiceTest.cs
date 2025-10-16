

using Tyuiu.AfoninME.Sprint2.Task1.V12.Lib;

namespace Tyuiu.AfoninME.Sprint2.Task1.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void GetLogicOperationsReturnsExpectedSequence()
        {
            var ds = new DataService();

            int a = 152;
            int b = 116;
            int c = 887;
            int d = 556;

            bool[] expected = { true, true, true, false, true, false };
            bool[] actual = ds.GetLogicOperations(a, b, c, d);

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}