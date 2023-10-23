using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.UleevRI.Sprint3.Task3.V8.Lib
{
    public class DataService : ISprint3Task3V8
    {
        public int ConvertStringToInt(string value)
        {
            string num = "";
            foreach (char i in value)
            {
                if (Char.IsDigit(i)) num += i;
            }
            int m = Convert.ToInt32(num);
            return m;
        }
    }
}
