using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppearanceCount
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrSize = int.Parse(Console.ReadLine());
            int[] array = Console.ReadLine()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();
            int numberToCheck = int.Parse(Console.ReadLine());
            Console.WriteLine(ElementCounter(array, numberToCheck));
        }
        static int ElementCounter(int[] arr, int element)
        {
            int result = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == element)
                {
                    result++;
                }
            }
            return result;
        }
    }
}
