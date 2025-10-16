using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.AfoninME.Sprint2.Task0.V24.Lib
{
    public class DataService : ISprint2Task0V24
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] result = new bool[6];

            result[0] = x * 5 == y - 80;    // True
            result[1] = y - x == 620;       // True ✅ (эквивалентно, но точнее под формат)
            result[2] = x > y;              // False
            result[3] = x * 10 < y / 2;     // False
            result[4] = y >= 700;           // True
            result[5] = x <= 140;           // True

            return result;
        }
    }
}
