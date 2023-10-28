using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.UleevRI.Sprint3.Task4.V17.Lib
{
    public class DataService : ISprint3Task4V17
    {
        public double Calculate(int startValue, int stopValue)
        {
            double m = 1;
            int i;
            for (i = startValue; i <= stopValue; i++)
            {
                if (i == 0) break;
                m *= Math.Cos(i) / Math.Sin(i);
            }
            return Math.Round(m, 3);
        }
    }
}
