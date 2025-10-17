using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.AfoninME.Sprint2.Task5.V1.Lib
{
    public class DataService : ISprint2Task5V1
    {
        public int FindMonthDaysCount(int value)
        {
            int days;

            switch (value)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    days = 31;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    days = 30;
                    break;
                case 2:
                    days = 28; 
                    break;
                default:
                    days = 0; 
                    break;
            }

            return days;
        }
    }
}