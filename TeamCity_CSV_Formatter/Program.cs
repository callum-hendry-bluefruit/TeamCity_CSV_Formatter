using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamCity_CSV_Formatter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] csvData;

            FileAccessClass AccessFile = new FileAccessClass();
            csvData = AccessFile.ReadCsv();

            ParsingClass CsvParser = new ParsingClass(csvData);
            string[] formattedCsv = CsvParser.Parse(); //Use something more descriptive than "Go"? "Parse"? "Format"?

            FormattingClass parsedCsvFormatter = new FormattingClass(formattedCsv);
        }
    }
}