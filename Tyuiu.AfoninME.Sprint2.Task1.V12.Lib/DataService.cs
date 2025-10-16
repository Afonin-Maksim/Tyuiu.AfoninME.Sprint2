using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.AfoninME.Sprint2.Task1.V12.Lib
{
    public class DataService : ISprint2Task1V12
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] result = new bool[6];

            // Должно выйти: (True, True, True, False, True, False)
            result[0] = (a > b) & (c > d);             // True
            result[1] = (a != b) || (c < d);           // True
            result[2] = (a <= c) && (d < c);           // True
            result[3] = (a < b) && (c > d);            // False
            result[4] = (a + b < c) && (d < c);        // True
            result[5] = (a > d) & (b == 200);          // False

            return result;
        }
    }
}