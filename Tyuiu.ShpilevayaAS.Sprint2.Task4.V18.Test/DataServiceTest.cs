using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShpilevayaAS.Sprint2.Task4.V18.Lib;

namespace Tyuiu.ShpilevayaAS.Sprint2.Task4.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 6;
            double res = ds.Calculate(x, y);
            double wait = 6;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCalculate2()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            double res = ds.Calculate(x, y);
            double wait = 20;
            Assert.AreEqual(wait, res);
        }
    }
}
