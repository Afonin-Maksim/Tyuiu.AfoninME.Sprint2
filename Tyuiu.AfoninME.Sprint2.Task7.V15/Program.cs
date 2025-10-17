using Tyuiu.AfoninME.Sprint2.Task7.V15.Lib;

namespace Tyuiu.AfoninME.Sprint2.Task7.V15
{
    internal class Program
    {
        static void Main()
        {
            var ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Афонин М.Е. | ИСТНб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнил: Афонин Максим Евгеньевич | ИСТНб-25-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает X и Y и определяет,             *");
            Console.WriteLine("* находится ли точка в заштрихованной области на рисунке.                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите X: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите Y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            bool res = ds.CheckDotInShadedArea(x, y);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            if (res)
                Console.WriteLine($"Точка ({x}; {y}) находится в заштрихованной области.");
            else
                Console.WriteLine($"Точка ({x}; {y}) НЕ находится в заштрихованной области.");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Программа завершена                                                     *");
            Console.WriteLine("***************************************************************************");
        }
    }
}