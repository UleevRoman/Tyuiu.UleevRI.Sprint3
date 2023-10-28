﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.UleevRI.Sprint3.Task5.V27.Lib;

namespace Tyuiu.UleevRI.Sprint3.Task5.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 2;
            int startValue1 = 1;
            int stopValue1 = 3;
            int startValue2 = 1;
            int stopValue2 = 10;
            double res = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);
            double wait = -1495.954;
            Assert.AreEqual(wait, res);
        }
    }
}
