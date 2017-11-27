using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace integerCalculations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();
            Console.WriteLine(Minimum(arr));
            Console.WriteLine(Maximum(arr));
            Console.WriteLine("{0:f2}", Average(arr));
            Console.WriteLine(Sum(arr));
            Console.WriteLine(Product(arr));

        }
        static BigInteger Product(int[] arr)
        {
            BigInteger result = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                result *= arr[i];
            }
            return result;
        }
        static int Sum(int[] arr)
        {
            int result = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                result += arr[i];
            }
            return result;
        }
        static double Average(int[] arr)
        {
            double result = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                result += arr[i];
            }
            return result / arr.Length;
        }
        static int Maximum(int[] arr)
        {
            int result = int.MinValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (result < arr[i])
                {
                    result = arr[i];
                }
            }
            return result;
        }
        static int Minimum(int[] arr)
        {
            int result = int.MaxValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (result>arr[i])
                {
                    result = arr[i];
                }
            }
            return result;
        }
    }
}
