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
            string[,] csvData; //Not sure of format yet; probably a 2d string array

            FileAccessClass AccessFile = new FileAccessClass();
            csvData = AccessFile.ReadCsv();

            ParseAndFormatLogicClass MainLogic = new ParseAndFormatLogicClass(csvData);
            MainLogic.Go(); //Use something more descriptive than "Go"? "Parse"? "Format"?
        }
    }
}
