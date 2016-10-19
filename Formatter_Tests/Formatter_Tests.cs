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
            string[] mockCsvData = { "1st_section,2nd_section,3rd_section", "4th_section,5th_section,6th_section" };
            ParsingClass Parser = new CSV_Formatter.ParsingClass();
            string[,] mockParsedCsvData = Parser.Parse(mockCsvData);
            string[,] expectedParsedCsvData = { { "1st_section", "2nd_section", "3rd_section" },
                                                { "4th_section", "5th_section", "6th_section" } };
            Assert.AreEqual(expectedParsedCsvData, mockParsedCsvData);
        }
    }
}
