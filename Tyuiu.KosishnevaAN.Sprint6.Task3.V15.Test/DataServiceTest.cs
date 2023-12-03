﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KosishnevaAN.Sprint6.Task3.V15.Lib;

namespace Tyuiu.KosishnevaAN.Sprint6.Task3.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {

            DataService ds = new DataService();
            int[,] valueArray = { { 33, 28, 31, 19, 4 },
                { 1, 32, -3, -17, -12 },
                { 24, -19, 26, 31, -3 },
                { 30, -16, 29, 28, 8 },
                { 30, 5, 11, 7, 32 }, };
            int[,] res = ds.Calculate(valueArray);

            int[,] wait = { { 33, 28, -3, 19, 4 },
                { 1, 32, 11, -17, -12 },
                { 24, -19, 26, 31, -3 },
                { 30, -16, 29, 28, 8 },
                { 30, 5, 31, 7, 32 }, };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
