using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShpilevayaAS.Sprint2.Task5.V9.Lib;

namespace Tyuiu.ShpilevayaAS.Sprint2.Task5.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfNextDay()
        {
            DataService ds = new DataService();

            Assert.AreEqual(3112, ds.FindDateOfNextDay(30, 12));
            Assert.AreEqual(109, ds.FindDateOfNextDay(31, 8));
            Assert.AreEqual(103, ds.FindDateOfNextDay(28, 2));
            Assert.AreEqual(1212, ds.FindDateOfNextDay(11, 12));


        }
    }
}
