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


        public void PrintToTxt(string[,] csvToPrint)
        {
            string textFilePath = "../../../Formatted_Text.txt";
            System.IO.StreamWriter writeToText = new System.IO.StreamWriter(textFilePath);
            string output = "";

            for (int i = 0; i < csvToPrint.GetLength(0); i++)
            {
                output = "";
                if (csvToPrint[i,0] == " ")
                {
                    output += "    " + csvToPrint[i, 1].ToString();
                    writeToText.WriteLine(output);
                }
                else
                {
                    writeToText.WriteLine("");
                    output += csvToPrint[i, 0].ToString();
                    writeToText.WriteLine(output);

                    output = "";
                    output += "    " + csvToPrint[i, 1].ToString();
                    writeToText.WriteLine(output);
                }
            }
        }
    }
}
