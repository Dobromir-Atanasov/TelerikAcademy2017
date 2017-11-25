using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isItCorect = true;
            int result = 0;
            string tokenInput = Console.ReadLine();
            for (int i = 0; i < tokenInput.Length; i++)
            {
                if (tokenInput[i]=='(')
                {
                    result++;
                }
                if (tokenInput[i]==')')
                {
                    result--;
                }
                if (result<0)
                {
                    isItCorect = false;
                    break;
                }
            }
            if (result!=0)
            {
                isItCorect = false;
            }
            if (isItCorect)
            {
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("Incorrect");
            }
        }
    }
}
