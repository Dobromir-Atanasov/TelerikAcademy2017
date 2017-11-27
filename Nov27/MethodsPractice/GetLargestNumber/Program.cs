using System;
using System.Linq;

namespace GetLargestNumber
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int result = GetMax(input[0], input[1]);
            Console.WriteLine(GetMax(result, input[2]));
        }
        static int GetMax(int first, int second)
        {
            if (first>second)
            {
                return first;
            }
            return second;
        }
    }
}
