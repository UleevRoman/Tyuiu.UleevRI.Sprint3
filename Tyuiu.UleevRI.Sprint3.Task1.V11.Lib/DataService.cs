using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.UleevRI.Sprint3.Task1.V11.Lib
{
    public class DataService : ISprint3Task1V11
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double sum = 1;
            int i;
            for (i = startValue; i <= stopValue; i++) sum *= (Math.Pow(value, i) + 0.5);
            return Math.Round(sum, 3);
        }
    }
}
