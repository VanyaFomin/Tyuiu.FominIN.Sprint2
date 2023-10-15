using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.FominIN.Sprint2.Task1.V8.Lib;

namespace Tyuiu.FominIN.Sprint2.Task1.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                DataService ds = new DataService();

                Console.Title = "Спринт #2 | Выполнил: Фомин И. Н. | ПКТб-23-1";
                Console.WriteLine("********************************************************************************");
                Console.WriteLine("* Спринт #2                                                                    *");
                Console.WriteLine("* Тема: Алгоритмы разветвляющейся структуры                                    *");
                Console.WriteLine("* Задание #1                                                                   *");
                Console.WriteLine("* Вариант #8                                                                   *");
                Console.WriteLine("* Выполнил: Фомин Иван Николаевич | ПКТб-23-1                                  *");
                Console.WriteLine("********************************************************************************");
                Console.WriteLine("* УСЛОВИЕ:                                                                     *");
                Console.WriteLine("* Написать программу из операций сравнений и логических операций               *");
                Console.WriteLine("********************************************************************************");
                Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
                Console.WriteLine("********************************************************************************");

                int a = 15;
                int b = 16;
                int c = 14;
                int d = 335;
                bool[] res = new bool[6];
                res = ds.GetLogicOperations(a, b, c, d);

                Console.WriteLine("a = " + a);
                Console.WriteLine("b = " + b);
                Console.WriteLine("c = " + c);
                Console.WriteLine("d = " + d);

                Console.WriteLine("********************************************************************************");
                Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
                Console.WriteLine("********************************************************************************");

                foreach (bool value in res)
                {
                    Console.WriteLine(value);
                }

                Console.ReadKey();
            }
        }

    }
}
