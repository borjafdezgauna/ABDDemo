using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MiniSQLEngine;

namespace MiniSQLParsing
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MiniSQLParse1()
        {
            string result;
            Engine engine = new Engine();
            engine.Query("SELECT * FROM table1", out result);
            Assert.AreEqual(Constants.NotImplemented, result);
        }
    }
}
