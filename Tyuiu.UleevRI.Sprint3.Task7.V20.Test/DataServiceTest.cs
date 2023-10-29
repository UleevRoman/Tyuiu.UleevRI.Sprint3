using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.UleevRI.Sprint3.Task7.V20.Lib;

namespace Tyuiu.UleevRI.Sprint3.Task7.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            int l = stopValue - startValue + 1;
            double[] num = new double[l];
            num[0] = 17.27;
            num[1] = 14.08;
            num[2] = 10.27;
            num[3] = 6.65;
            num[4] = 3.87;
            num[5] = 0.00;
            num[6] = -0.74;
            num[7] = -3.71;
            num[8] = -7.59;
            num[9] = -11.55;
            num[10] = -14.74;
            double[] res = new double[l];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(num, res);
        }
    }
}
