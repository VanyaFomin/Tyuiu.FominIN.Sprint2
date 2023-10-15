using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.FominIN.Sprint2.Task0.V6.Lib;

namespace Tyuiu.FominIN.Sprint2.Task0.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Фомин И. Н. | ПКТб-23-1";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Спринт #2                                                                    *");
            Console.WriteLine("* Тема: Алгоритмы разветвляющейся структуры                                    *");
            Console.WriteLine("* Задание #0                                                                   *");
            Console.WriteLine("* Вариант #6                                                                   *");
            Console.WriteLine("* Выполнил: Фомин Иван Николаевич | ПКТб-23-1                                  *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                     *");
            Console.WriteLine("* Написать программу из операций сравнений ==, !=, <, >, <=, >=                *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("********************************************************************************");

            int x = 107;
            int y = 754;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);

            Console.WriteLine("X = " + x);
            Console.WriteLine("Y = " + y);

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
