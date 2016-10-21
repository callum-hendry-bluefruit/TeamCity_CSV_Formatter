using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSV_Formatter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] csvData;
            string[] unreadableCsv = { "NO_CSV" };
            string pathToCsv = "../../../CoSimplex_ABSW_53-tests.csv";

            FileAccessClass AccessFile = new FileAccessClass();
            csvData = AccessFile.ReadCsv(pathToCsv).Skip(1).ToArray(); //In addition to getting the CSV data, 
                                                                       //it skips the 1st element of the array, 
                                                                       //as that is not useful data.

            if (csvData[0] == unreadableCsv[0])
            {
                MessageBox.Show("No CSV found. Press OK to exit", "ERROR");
                Environment.Exit(404);
            }

            ParsingClass CsvParser = new ParsingClass();
            string[,] seperatedCsv = CsvParser.Parse(csvData);

            FormattingClass parsedCsvFormatter = new FormattingClass();
            string[,] humanReadableCsv = parsedCsvFormatter.Format(seperatedCsv);

            AccessFile.PrintToTxt(humanReadableCsv);
        }
    }
}