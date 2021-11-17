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
            char[] chars = input.ToCharArray();

            for(int i = 0; i < chars.Length; i++)
            {
                UniqueChar uniqueChar = uniqueChars.Find(unique => unique.Value == chars[i]);
               
                chars[i] = uniqueChar.IsSingle ? singleChar : recurringChar;
            }
            return new string(chars);
        }
    }
}
