using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.FominIN.Sprint2.Task2.V8.Lib
{
    public class DataService : ISprint2Task2V8
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;

            if ((x >= 3) && (x <= 14) && (y >= 3) && (y <= 14))
            {
                res = true;
            }
            else
            {
                res = false;
            }

            return res;

        }
    }
}
