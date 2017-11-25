using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeriesOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string tokenInput = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            char currentChar = tokenInput[0];
            sb.Append(currentChar);
            for (int i = 1; i < tokenInput.Length; i++)
            {
                if (currentChar!=tokenInput[i])
                {
                    currentChar = tokenInput[i];
                    sb.Append(currentChar);
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
