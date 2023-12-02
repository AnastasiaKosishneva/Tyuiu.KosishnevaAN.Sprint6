using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KosishnevaAN.Sprint6.Task0.V16.Lib;

namespace Tyuiu.KosishnevaAN.Sprint6.Task0.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            DataService ds = new DataService();
            string res = ds.SaveToFileTextData(3);
            string wait = "3,111";
            Assert.AreEqual(wait, res);
        }
    }
}
