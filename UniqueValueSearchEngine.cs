using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringConversion
{
    class UniqueValueSearchEngine
    {
        private List<UniqueChar> uniqueChars;
       
        public List<UniqueChar> Start(string input)
        {
            uniqueChars = new List<UniqueChar>();

            while(input.Length > 0)
            {
                int i = 0;
                char ch = input[i];
                bool isSingle = true;

                for (int j = 1; j < input.Length; j++)
                {
                    if (input[i] == input[j])
                    {
                        isSingle = false;
                    }
                }

                input = input.Replace(ch.ToString(), "");

                UniqueChar uniqueChar = new UniqueChar();
                uniqueChar.Value = ch;

                if (!isSingle)
                {
                    uniqueChar.IsSingle = false;
                }
                else
                {
                    uniqueChar.IsSingle = true;
                }
                uniqueChars.Add(uniqueChar);
            }
            return uniqueChars;
        }
    }
}
