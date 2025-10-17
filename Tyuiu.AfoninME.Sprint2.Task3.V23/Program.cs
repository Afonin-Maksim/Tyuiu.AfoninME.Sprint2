using Tyuiu.AfoninME.Sprint2.Task3.V23.Lib;

namespace Tyuiu.AfoninME.Sprint2.Task3.V23
{
    internal class Program
    {
        static void Main()
        {
            var ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Афонин М. Е. | ИСТНб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Вложенные операторы if - else                                     *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #23                                                             *");
            Console.WriteLine("* Выполнил: Афонин Максим Евгеньевич | ИСТНб-25-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет значение функции Y с              *");
            Console.WriteLine("* использованием вложенных операторов if-else. Округлить результат        *");
            Console.WriteLine("* до трёх знаков после запятой.                                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите значение X: ");
            double x = Convert.ToDouble(Console.ReadLine());

            double y = ds.Calculate(x);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Y = {y}");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Программа завершена                                                     *");
            Console.WriteLine("***************************************************************************");
        }
    }
}
