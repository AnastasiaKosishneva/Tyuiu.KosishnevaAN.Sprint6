using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KosishnevaAN.Sprint6.Task6.V25.Lib;

namespace Tyuiu.KosishnevaAN.Sprint6.Task6.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void validCollectTextFromFile()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\Lenovo\Desktop\DataSprint6\InPutFileTask6V25.txt";

            string res = ds.CollectTextFromFile(path);
            string wait = " ELHLVt EgQpG dsE jiUFMDjMsEervIz ZujmucpYQE";

            Assert.AreEqual(wait, res);
        }
    }
}
