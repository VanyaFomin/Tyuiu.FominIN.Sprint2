using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.FominIN.Sprint2.Task7.V10.Lib;

namespace Tyuiu.FominIN.Sprint2.Task7.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();

            double x = 1.0;
            double y = 2.0;

            bool res = ds.CheckDotInShadedArea(x, y);

            bool wait = false;

            Assert.AreEqual(wait, res);
        }
    }
}
