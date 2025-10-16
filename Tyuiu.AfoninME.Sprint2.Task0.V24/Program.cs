using System;
using Tyuiu.AfoninME.Sprint2.Task0.V24.Lib;

namespace Tyuiu.AfoninME.Sprint2.Task0.V24
{
    internal class Program
    {
        static void Main()
        {
            var ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Афонин М. Е. | ИСТНб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Операции сравнения.                                               *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #24                                                             *");
            Console.WriteLine("* Выполнил: Афонин Максим Евгеньевич | ИСТНб-25-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу из операций сравнений и арифметических выражений,     *");
            Console.WriteLine("* которая вернет логическую последовательность (True, True, False, False,  *");
            Console.WriteLine("* True, True) при x = 135, y = 755.                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x = 135;
            int y = 755;

            Console.WriteLine($"x = {x}");
            Console.WriteLine($"y = {y}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            bool[] result = ds.GetCompareOperations(x, y);

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine($"Результат {i + 1}: {result[i]}");
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Программа завершена                                                     *");
            Console.WriteLine("***************************************************************************");
        }
    }
}