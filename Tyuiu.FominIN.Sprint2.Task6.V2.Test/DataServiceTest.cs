using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.FominIN.Sprint2.Task6.V2.Lib;

namespace Tyuiu.FominIN.Sprint2.Task6.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindMonthSeason()
        {
            DataService ds = new DataService();

            string season = ds.FindMonthSeason(6);

            Assert.AreEqual("Лето", season);
        }
    }
}
