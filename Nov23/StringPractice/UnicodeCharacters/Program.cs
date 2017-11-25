using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicodeCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string tokenInput = Console.ReadLine();
            for (int i = 0; i < tokenInput.Length; i++)
            {
                char toPrint = tokenInput[i];
                Console.Write("\\u" + ((int)toPrint).ToString("X").PadLeft(4, '0'));
            }
        }
    }
}
