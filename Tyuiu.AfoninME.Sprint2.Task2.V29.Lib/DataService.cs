using tyuiu.cources.programming.interfaces.Sprint2;
using System;

namespace Tyuiu.AfoninME.Sprint2.Task2.V29.Lib
{
    public class DataService : ISprint2Task2V29
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            // Область взята с рисунка (вариант 29).
            // Условия выделены по координатам, где закрашенные клетки есть на рисунке.

            bool res = false;

            // Верхняя горизонталь (y = 3) — с x от 2 до 13
            if (y == 3 && x >= 2 && x <= 13) res = true;

            // Средняя "палка" на y = 4, x от 2 до 13
            if (y == 4 && x >= 2 && x <= 13) res = true;

            // Средняя нижняя часть (y = 5–6) — x от 6 до 11
            if ((y == 5 || y == 6) && x >= 6 && x <= 11) res = true;

            // Нижняя правая ножка (y = 7–8) — x от 10 до 11
            if ((y == 7 || y == 8) && (x == 10 || x == 11)) res = true;

            // Левая нижняя ножка (y = 9–11) — x = 3
            if (y >= 9 && y <= 11 && x == 3) res = true;

            // Нижний квадрат (y = 11–12) — x = 9
            if ((y == 11 || y == 12) && x == 9) res = true;

            return res;
        }
    }
}