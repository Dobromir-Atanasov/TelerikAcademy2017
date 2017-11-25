using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseTags
{
    class Program
    {
        static void Main(string[] args)
        {
            string tokenInput = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            do
            {
                int startIndex = tokenInput.IndexOf("<upcase>");
                int endIndex = tokenInput.IndexOf("</upcase>");
                if (startIndex>=0)
                {
                    sb.Append(tokenInput.Substring(0, startIndex));
                    sb.Append(tokenInput.Substring(startIndex + 8, endIndex-(startIndex+8)).ToUpper());
                    tokenInput = tokenInput.Substring(endIndex + 9);
                }
            } while (tokenInput.Contains("<upcase>"));
            sb.Append(tokenInput);
            Console.WriteLine(sb.ToString());
        }
    }
}
