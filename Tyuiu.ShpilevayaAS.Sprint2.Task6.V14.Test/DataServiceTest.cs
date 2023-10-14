using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShpilevayaAS.Sprint2.Task6.V14.Lib;

namespace Tyuiu.ShpilevayaAS.Sprint2.Task6.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDayName()
        {
            DataService ds = new DataService();

            int k = 14;
            int d = 7;
            int t = (d + k - 2) % 7;

            string res = ds.FindDayName(t);
            string wait = "Суббота";

            Assert.AreEqual(wait, res);
        }
    }
}
