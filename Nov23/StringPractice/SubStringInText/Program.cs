using System;

namespace SubStringInText
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = Console.ReadLine().ToLower();
            string theText = Console.ReadLine().ToLower();
            string result = theText.Replace(pattern, "");
            Console.WriteLine((theText.Length-result.Length)/pattern.Length);
        }
    }
}
