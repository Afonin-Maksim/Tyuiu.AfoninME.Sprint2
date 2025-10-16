using tyuiu.cources.programming.interfaces.Sprint2;
using System;

namespace Tyuiu.AfoninME.Sprint2.Task2.V29.Lib
{
    public class DataService : ISprint2Task2V29
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            

            bool res = false;

            
            if (y == 3 && x >= 2 && x <= 13) res = true;

            
            if (y == 4 && x >= 2 && x <= 13) res = true;

            
            if ((y == 5 || y == 6) && x >= 6 && x <= 11) res = true;

            
            if ((y == 7 || y == 8) && (x == 10 || x == 11)) res = true;

            
            if (y >= 9 && y <= 11 && x == 3) res = true;

            
            if ((y == 11 || y == 12) && x == 9) res = true;

            return res;
        }
    }
}