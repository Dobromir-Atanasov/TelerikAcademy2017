using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractSentences
{
    class Program
    {
        static void Main(string[] args)
        {
            string words = Console.ReadLine().Trim();
            words = " " + words + " ";
            string[] sentences = Console.ReadLine()
                .Split(new [] { "."}, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < sentences.Length; i++)
            {
                if (sentences[i].Contains(words))
                {
                    sb.Append(sentences[i]);
                    sb.Append(".");
                }
            }
            Console.WriteLine(sb);
        }
    }
}
