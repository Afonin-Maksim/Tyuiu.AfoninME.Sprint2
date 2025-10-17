using Tyuiu.AfoninME.Sprint2.Task6.V9.Lib;

namespace Tyuiu.AfoninME.Sprint2.Task6.V9
{
    internal class Program
    {
        static void Main()
        {
            var ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Афонин М. Е. | ИСТНб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Получение результата из switch                                    *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполнил: Афонин Максим Евгеньевич | ИСТНб-25-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дата задается месяцем (m) и числом (n). Определить дату следующего дня, *");
            Console.WriteLine("* считая, что дата не является 31 декабря.                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите номер месяца (1-12): ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите число (1–31): ");
            int n = Convert.ToInt32(Console.ReadLine());

            string result = ds.FindDateOfNextDay(m, n);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Следующая дата: {result}");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Программа завершена                                                     *");