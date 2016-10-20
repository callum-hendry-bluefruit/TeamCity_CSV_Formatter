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
            /* ~~~ Example code for iterating through a string's chars ~~~
            string foo = "hello world", bar = string.Empty;
            foreach(char c in foo)
            {
                bar += c;
            }
            */
            int lengthOfParsedCsvDataArray = 4; //Should match number of columns in CSV file

            string[,] parsedCsvData = new string[csvData.Length, lengthOfParsedCsvDataArray]; //[Y,X]
            int xCoordinateOfArray = 0;
            for (int i = 0; i < csvData.Length; i++)
            {
                string stringBuffer = string.Empty;
                string itemToParse = csvData[i];

                foreach (char c in itemToParse) //Doesn't parse the 3rd_section part. Use a for loop with string.length as stop param. Can use string[j] as method to access chars in string.
                {
                    if (c == ',')
                    {
                        parsedCsvData[i, xCoordinateOfArray] = stringBuffer;
                        stringBuffer = "";

                        xCoordinateOfArray += 1;
                        if (xCoordinateOfArray > (lengthOfParsedCsvDataArray - 1))
                        {
                            xCoordinateOfArray = 0;
                        }
                    }
                    else
                    {
                        stringBuffer += c;
                    }
                }
            }

            return parsedCsvData;
        }
    }
}
