﻿using System;
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
            string[,] temp = { { "" } };
            return temp;
        }

        private string[] SeperateLineIntoSections(string line)
        {
            /* ~~~ Example code for iterating through a string's chars ~~~
            string foo = "hello world", bar = string.Empty;
            foreach(char c in foo)
            {
                bar += c;
            }
            */

            string[] temp = { "" };
            return temp;
        }
    }
}
