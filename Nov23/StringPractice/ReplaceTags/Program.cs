using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceTags
{
    class Program
    {
        static void Main(string[] args)
        {
            string tokenInput = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            int startIndex = 0;
            int endIndex = 0;
            int indexOfEndDescription = 0;
            do
            {
                startIndex = tokenInput.IndexOf("<a href=");
                endIndex = tokenInput.IndexOf(">");
                indexOfEndDescription = tokenInput.IndexOf("</a>");

                string link = "(" + tokenInput.Substring(startIndex + 8, endIndex - startIndex-8) +")";
                string description = "[" + tokenInput.Substring(endIndex + 1, indexOfEndDescription - endIndex - 1) + "]";

                sb.Append(tokenInput.Substring(0, startIndex));
                sb.Append(description);
                sb.Append(link);

                tokenInput.Substring(indexOfEndDescription + 4);
            } while (startIndex>=0&&endIndex>=0);
        }
    }
}
