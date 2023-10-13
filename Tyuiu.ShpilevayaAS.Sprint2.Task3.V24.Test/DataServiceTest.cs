using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShpilevayaAS.Sprint2.Task3.V24.Lib;

namespace Tyuiu.ShpilevayaAS.Sprint2.Task3.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate1()
        {
            DataService ds = new DataService();
            double x = 1;
            double res = ds.Calculate(x);
            double wait = 10.988;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCalculate2()
        {
            DataService ds = new DataService();
            double x = 0;
            double res = ds.Calculate(x);
            double wait = double.PositiveInfinity;
            Assert.AreEqual(wait, res);

        }

        [TestMethod]
        public void ValidCalculate3()
        {
            DataService ds = new DataService();
            double x = -1;
            double res = ds.Calculate(x);
            double wait = 0.5;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCalculate4()
        {
            DataService ds = new DataService();
            double x = -30;
            double res = ds.Calculate(x);
            double wait = 600.033;
            Assert.AreEqual(wait, res);
        }

    }
}
