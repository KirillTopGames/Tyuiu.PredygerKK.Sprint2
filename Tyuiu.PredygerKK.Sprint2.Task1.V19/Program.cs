using Tyuiu.PredygerKK.Sprint2.Task1.V19.Lib;

namespace Tyuiu.PredygerKK.Sprint2.Task1.V19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;
            a = 696;
            b = 354;
            c = 423;
            d = 957;
            DataService ds = new DataService();
            bool[] res = ds.GetLogicOperations(a, b, c, d);

            Console.Title = "Спринт #2 | Выполнил: Предыгер К.К. | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Логические операции                                               *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #19                                                             *");
            Console.WriteLine("* Выполнил: Предыгер Кирилл Константинович | ПКТб-24-1                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу из операций сравнений                                *");
            Console.WriteLine("* (==, !=, <, >, <=, >=, последовательность можно чередовать, но          *");
            Console.WriteLine("* использовать один раз в выражении) и логических операций (|, &, ||,     *");
            Console.WriteLine("* &&, !, ^, последовательность операций не должна нарушаться), а также    *");
            Console.WriteLine("* арифметических выражений, которая вернет логическую                     *");
            Console.WriteLine("* последовательность(массив): (True, False, True, False, True, False),    *");
            Console.WriteLine("* при a = 696, b = 354, c = 423, d = 957                                  *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("a:" + a);
            Console.WriteLine("b:" + b);
            Console.WriteLine("c:" + c);
            Console.WriteLine("d:" + d);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine(res[i]);
            }

        }
    }
}
