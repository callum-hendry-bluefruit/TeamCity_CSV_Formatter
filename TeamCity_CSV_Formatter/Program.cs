using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV_Formatter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] csvData;

            FileAccessClass AccessFile = new FileAccessClass();
            csvData = AccessFile.ReadCsv();

            ParsingClass CsvParser = new ParsingClass();
            string[,] seperatedCsv = CsvParser.Parse(csvData);

            FormattingClass parsedCsvFormatter = new FormattingClass();
            string[] humanReadableCsv = parsedCsvFormatter.Format(seperatedCsv);
        }
    }
}