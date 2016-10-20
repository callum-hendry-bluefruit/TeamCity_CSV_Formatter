using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSV_Formatter;

namespace Formatter_Tests
{
    [TestClass]
    public class Formatter_Tests
    {
        //Seperation tests
        [TestMethod]
        public void Seperate_line_into_sections_with_simple_example_data()
        {
            string[] mockCsvData = { "1st_section,2nd_section,3rd_section,4th_section", "5th_section,6th_section,7th_section,8th_section" };

            ParsingClass Parser = new CSV_Formatter.ParsingClass();
            string[,] mockParsedCsvData = Parser.Parse(mockCsvData);

            string[,] expectedParsedCsvData = { { "1st_section", "2nd_section", "3rd_section", "4th_section" },
                                                { "5th_section", "6th_section", "7th_section", "8th_section" } };
            CollectionAssert.AreEqual(expectedParsedCsvData, mockParsedCsvData);
        }

        [TestMethod]
        public void Seperate_a_real_line_copied_from_CSV_into_sections()
        {//Uses line copied from real CSV in format returned by File.ReadAllLines(string)
            string[] mockCsvData = { "1,VSTest: MonolithTests.NancyTests.RootModuleTests.when_unauthorized_get_on_root_url_should_redirect_us_to_login_page,OK,510" };

            ParsingClass Parser = new CSV_Formatter.ParsingClass();
            string[,] mockParsedCsvData = Parser.Parse(mockCsvData);

            string[,] expectedParsedCsvData = { { "1", "VSTest: MonolithTests.NancyTests.RootModuleTests.when_unauthorized_get_on_root_url_should_redirect_us_to_login_page", "OK", "510" } };
            CollectionAssert.AreEqual(expectedParsedCsvData, mockParsedCsvData);
        }

        //Formatting tests
        [TestMethod]
        public void Format_parsed_data_copied_from_real_CSV_in_expected_format()
        {//Uses real line from CSV in the expected format after parsing.
            string[,] parsedCsvData = { { "1", "VSTest: MonolithTests.NancyTests.RootModuleTests.when_unauthorized_get_on_root_url_should_redirect_us_to_login_page", "OK", "510" }};

            string[] expectedFormattedData = { "RootModuleTests", "When unauthorized get on root url should redirect us to login page"};

            FormattingClass Formatter = new FormattingClass();
            string[] mockFormattedData = Formatter.Format(parsedCsvData);
            CollectionAssert.AreEqual(expectedFormattedData, mockFormattedData);
        }

        [TestMethod]
        public void Format_parsed_data_with_two_tests_from_same_group()
        {//Uses real line from CSV in the expected format after parsing.
            string[,] parsedCsvData = { { "1", "VSTest: MonolithTests.NancyTests.RootModuleTests.when_unauthorized_get_on_root_url_should_redirect_us_to_login_page", "OK", "510" },
                                        { "2", "VSTest: MonolithTests.NancyTests.RootModuleTests.when_authorized_as_an_analyst_get_on_root_should_provide_rulesupload_view", "OK", "198" } };

            string[,] expectedFormattedData = { { "RootModuleTests", "When unauthorized get on root url should redirect us to login page" },
                                                { "", "When authorized as an analyst get on root should provide rulesupload view" } };

            FormattingClass Formatter = new FormattingClass();
            string[] mockFormattedData = Formatter.Format(parsedCsvData);
            CollectionAssert.AreEqual(expectedFormattedData, mockFormattedData);
        }

        [TestMethod]
        public void Format_parsed_data_with_a_test_from_two_different_groups()
        {//Uses real line from CSV in the expected format after parsing.
            string[,] parsedCsvData = { { "1", "VSTest: MonolithTests.NancyTests.RootModuleTests.when_unauthorized_get_on_root_url_should_redirect_us_to_login_page", "OK", "510" },
                                        { "7", "VSTest: MonolithTests.NancyTests.UploadModuleTests.get_on_upload_root_url_gives_us_OK_status", "OK", "86" } };

            string[,] expectedFormattedData = { { "RootModuleTests", "When unauthorized get on root url should redirect us to login page" },
                                                { "UploadModuleTests", "Get on upload root url gives us OK status" } };

            FormattingClass Formatter = new FormattingClass();
            string[] mockFormattedData = Formatter.Format(parsedCsvData);
            CollectionAssert.AreEqual(expectedFormattedData, mockFormattedData);
        }
    }
}
