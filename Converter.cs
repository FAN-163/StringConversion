using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringConversion
{
    public class Converter
    {
        char singleChar = '(';
        char recurringChar = ')';

        public string Сonversion(string input, List<UniqueChar> uniqueChars)
        {
            foreach (UniqueChar uniqueChar in uniqueChars)
            {
                if (uniqueChar.IsSingle)
                    input = input.Replace(uniqueChar.Value.ToString(), singleChar.ToString());
                
                else if(!uniqueChar.IsSingle)
                    input = input.Replace(uniqueChar.Value.ToString(), recurringChar.ToString());
            }
            return input;
        }
    }
}
