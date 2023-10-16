using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.FominIN.Sprint2.Task5.V4.Lib
{
    public class DataService : ISprint2Task5V4
    {
        public string FindCardSuit(int value)
        {
            string suit;
            switch (value)
            {
                case 1:
                    suit = "пики";
                    break;
                case 2:
                    suit = "трефы";
                    break;
                case 3:
                    suit = "бубны";
                    break;
                case 4:
                    suit = "червы";
                    break;
                default:
                    throw new ArgumentException("Invalid card suit value.");
            }

            return suit;
        }
    }
}
