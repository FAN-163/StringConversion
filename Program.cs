using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StringConversion
{
    public class Program
    {
        public static void Main(string[] args)
        {
            UniqueValueSearchEngine uniqueValueSearchEngine = new UniqueValueSearchEngine();
            Converter converter = new Converter();

            while (true)
            {
                Console.WriteLine("Веедите входную строку для конвертации, или exit для выхода");
                string inputString = Console.ReadLine().ToLower();
               
                if(inputString.Equals("exit"))
                {
                    return;
                }

                string conversionString = inputString;

                List<UniqueChar> uniqueChars = uniqueValueSearchEngine.Start(conversionString);
                
                conversionString = converter.Сonversion(conversionString, uniqueChars);

                Console.WriteLine(conversionString);
            }
        }
    }
}
