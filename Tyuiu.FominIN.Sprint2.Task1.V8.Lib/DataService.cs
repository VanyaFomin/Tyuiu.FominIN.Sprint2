﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.FominIN.Sprint2.Task1.V8.Lib
{
    public class DataService : ISprint2Task1V8
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = (a + 1 == b);
            res[1] = (a >= b) && !(c > d);
            res[2] = (a < b) || !(c > d);
            res[3] = !(c < d) && (d != a);
            res[4] = !(c > d) && (d <= a);
            res[5] = !(b > d) && (d <= a);

            return res;
        }
    }
    }

