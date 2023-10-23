using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.UleevRI.Sprint3.Task3.V8.Lib;

namespace Tyuiu.UleevRI.Sprint3.Task3.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string str = "vc,x12fc fc!e";
            int res = ds.ConvertStringToInt(str);
            int wait = 12;
            Assert.AreEqual(wait, res);
        }
    }
}
