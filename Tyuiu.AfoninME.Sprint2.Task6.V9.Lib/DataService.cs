using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.AfoninME.Sprint2.Task6.V9.Lib
{
    public class DataService : ISprint2Task6V9
    {
        public string FindDateOfNextDay(int m, int n)
        {
            
            int daysInMonth = m switch
            {
                1 or 3 or 5 or 7 or 8 or 10 or 12 => 31,
                4 or 6 or 9 or 11 => 30,
                2 => 28, 
                _ => 0
            };

            if (daysInMonth == 0 || n < 1 || n > daysInMonth)
            {
                return "Ошибка: введена некорректная дата.";
            }

            int nextDay = n;
            int nextMonth = m;

            if (n == daysInMonth)
            {
                nextDay = 1;
                nextMonth++;
            }
            else
            {
                nextDay = n + 1;
            }

            return $"{nextDay}.{nextMonth}";
        }
    }
}
