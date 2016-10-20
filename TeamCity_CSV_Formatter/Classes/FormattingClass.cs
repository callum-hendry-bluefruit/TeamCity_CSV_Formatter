using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV_Formatter
{
    public class FormattingClass
    {
        public string[] Format(string[,] parsedCsv)
        {// 1st_section - format of input on test - just remove the _ and replace with " " to pass test
            string[,] csvWithoutUnderscores = RemoveUnderscores(parsedCsv);

            return csvWithoutUnderscores;
        }

        private string[,] RemoveUnderscores(string[,] parsedCsvWithoutUnderscores)
        {
            for (int yCoordinate = parsedCsvWithoutUnderscores.GetLowerBound(0); yCoordinate <= parsedCsvWithoutUnderscores.GetUpperBound(0); ++yCoordinate)
            {
                for (int xCoordinate = parsedCsvWithoutUnderscores.GetLowerBound(1); xCoordinate <= parsedCsvWithoutUnderscores.GetUpperBound(1); ++xCoordinate)
                {
                    parsedCsvWithoutUnderscores[yCoordinate, xCoordinate] = parsedCsvWithoutUnderscores[yCoordinate, xCoordinate].Replace('_', ' ');
                }
            }

            return parsedCsvWithoutUnderscores;
        }
    }
}
