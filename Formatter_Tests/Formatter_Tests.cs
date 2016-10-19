using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Formatter_Tests
{
    [TestClass]
    public class Formatter_Tests
    {
        [TestMethod]
        public void SeperateLineIntoSections()
        {
            int temp1 = 1, temp2 = 2;
            Assert.AreEqual(temp1, temp2);
        }
    }
}
