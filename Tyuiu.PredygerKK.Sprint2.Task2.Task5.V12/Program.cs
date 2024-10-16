using Tyuiu.PredygerKK.Sprint2.Task2.Task5.V12.Lib;

namespace Tyuiu.PredygerKK.Sprint2.Task2.Task5.V12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int g, m, n;
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Предыгер К.К. | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор switch                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #12                                                             *");
            Console.WriteLine("* Выполнил: Предыгер Кирилл Константинович | ПКТб-24-1                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дата некоторого дня характеризуется тремя натуральными числами:         *");
            Console.WriteLine("* g (год), m (порядковый номер месяца) и n (число). По заданным g, n и m  *");
            Console.WriteLine("* определить дату предыдущего дня. Заданный год является високосным.      *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите значение год: ");
            g = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение месяц: ");
            m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение день: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Сегодня " + $"{g}.{m}.{n}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Вчерашняя дата " + ds.FindDateOfPreviousDay(g, m, n));
        }
    }
}
    

