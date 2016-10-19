using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSV_Formatter;

namespace Formatter_Tests
{
    [TestClass]
    public class Formatter_Tests
    {
        [TestMethod]
        public void SeperateLineIntoSections()
        {
            ParsingClass parser = new CSV_Formatter.ParsingClass();
            int temp1 = 1, temp2 = 2;
            Assert.AreEqual(temp1, temp2);
        }
    }
}
