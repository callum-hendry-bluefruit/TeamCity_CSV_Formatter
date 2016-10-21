using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV_Formatter
{
    public class FormattingClass
    {
        public string[,] Format(string[,] parsedCsv)
        {// Expected: { {"RootModuleTests", "When unauthorized get on root url should redirect us to login page"} }
            int heightOfParsedCsv = parsedCsv.GetLength(0);
            string[,] formattedCsv = new string[heightOfParsedCsv, 2]; //y,x

            for (int i = 0; i < heightOfParsedCsv; i++)
            {
                string lineWithoutUnderscores = RemoveUnderscores(parsedCsv[i, 1]); //Removes underscores from 2nd column (1) in parsedCsv and stores
                string[] usefulData = GetTestGroupNameAndTestName(lineWithoutUnderscores); //Split the underscore-free line and get back the TestGroupName and TestName

                formattedCsv[i,0] = usefulData[0]; //Put TestGroupName into first column of array on the same row it came from
                formattedCsv[i,1] = usefulData[1]; //Put TestName into second column of array on the same row it came from
            }

            return formattedCsv;
        }

        private string RemoveUnderscores(string parsedLineWithoutUnderscores)
        {
            parsedLineWithoutUnderscores = parsedLineWithoutUnderscores.Replace('_', ' ');
            return parsedLineWithoutUnderscores;
        }

        private string[] GetTestGroupNameAndTestName(string toBeSplit)
        {
            string[] splitLine = toBeSplit.Split('.');
            string[] usefulDataFromSplitLine = new string[2];

            usefulDataFromSplitLine[0] = splitLine[(splitLine.GetLength(0) - 1)]; //Get last item in array
            usefulDataFromSplitLine[1] = splitLine[(splitLine.GetLength(0) - 2)]; //Get 2nd to last item in array

            return usefulDataFromSplitLine;
        }
    }
}
