using System;

namespace StringPractice
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();
            Array.Reverse(input);
            Console.WriteLine(new String(input));
        }
    }
}
