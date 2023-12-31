﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.FominIN.Sprint2.Task5.V4.Lib;

namespace Tyuiu.FominIN.Sprint2.Task5.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindCardSuit()
        {
            DataService ds = new DataService();

            Assert.AreEqual("пики", ds.FindCardSuit(1));
            Assert.AreEqual("трефы", ds.FindCardSuit(2));
            Assert.AreEqual("бубны", ds.FindCardSuit(3));
            Assert.AreEqual("червы", ds.FindCardSuit(4));
        }
    }
}
