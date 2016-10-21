using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CSV_Formatter
{
    public class FileAccessClass
    {
        public string[] ReadCsv(string pathToCsv)
        { 
            if (File.Exists(pathToCsv))
            {
                string[] csvData = File.ReadAllLines(pathToCsv);
                return csvData;
            }
            else
            {
                string[] blank = { "NO_CSV" };
                return blank;
            }
        }

        public void PrintToTxt(string[,] textToPrint)
        {

        }
    }
}
