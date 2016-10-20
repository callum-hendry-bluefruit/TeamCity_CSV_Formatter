using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CSV_Formatter
{
    public class ParsingClass
    {
        public string[,] Parse(string[] csvData)
        {
            int lengthOfParsedCsvDataArray = 4; //Should match number of columns in CSV file

            string[,] parsedCsvData = new string[csvData.Length, lengthOfParsedCsvDataArray]; //[Y,X]

            for (int i = 0; i < csvData.Length; i++) //Y coordinate of parsedCsvData
            {
                string itemToParse = csvData[i];
                string[] splitString = itemToParse.Split(',');
                for (int j = 0; j < splitString.Length; j++)
                {
                    parsedCsvData[i,j] = splitString[j];
                }
            }

            return parsedCsvData;
        }
    }
}
