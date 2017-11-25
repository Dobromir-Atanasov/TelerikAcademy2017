using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringLenght
{
    class Program
    {
        static void Main(string[] args)
        {
            string tokenInput = Console.ReadLine();
            if (tokenInput.Length<20)
            {
                tokenInput += new string('*', 20 - tokenInput.Length);
            }
            Console.WriteLine(tokenInput);
        }
    }
}
