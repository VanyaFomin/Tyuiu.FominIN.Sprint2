using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.FominIN.Sprint2.Task3.V22.Lib;

namespace Tyuiu.FominIN.Sprint2.Task3.V22
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
            Console.WriteLine("* Задание #3                                                                   *");
            Console.WriteLine("* Вариант #22                                                                  *");
            Console.WriteLine("* Выполнил: Фомин Иван Николаевич | ПКТб-23-1                                  *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                     *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение функции Y с         *");
            Console.WriteLine("* использованием вложенных оператор if-else, где пользователь вводит значение  *");
            Console.WriteLine("* переменной X с клавиатуры                                                    *");
            Console.WriteLine("* Округлить полученное значение до трех знаков после запятой                   *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("********************************************************************************");

            Console.WriteLine("Введите значение переменной X: ");
            double x = Convert.ToDouble(Console.ReadLine());
            double res = ds.Calculate(x);

            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
            Console.WriteLine("********************************************************************************");

            Console.WriteLine("Значение функции = " + Math.Round(res, 3));
           
            Console.ReadKey();
        }
    }
}
