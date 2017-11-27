using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberAsArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tokenInput = Console.ReadLine()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();
            int largestArrLenght = 0;
            if (tokenInput[0]>=tokenInput[1])
            {
                largestArrLenght = tokenInput[0];
            }
            else
            {
                largestArrLenght = tokenInput[1];
            }
            int[] arrOne = Console.ReadLine()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();
            int[] arrTwo = Console.ReadLine()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();
            int[] arrResult = SumArrays(arrOne, arrTwo, largestArrLenght);
            PrintResult(arrResult, largestArrLenght);
        }
        static void PrintResult(int[] arr, int largestArrLenght)
        {
            if (arr[largestArrLenght]!=0)
            {
                largestArrLenght++;
            }
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < largestArrLenght-1; i++)
            {
                sb.Append(arr[i]);
                sb.Append(' ');
            }
            sb.Append(arr[largestArrLenght-1]);
            Console.WriteLine(sb);
        }

        static int[] SumArrays(int[] arrOne, int[] arrTwo, int largestArrLenght)
        {
            if (arrOne.Length>arrTwo.Length)
            {
                int[] arrResult = new int[largestArrLenght + 1];
                for (int i = 0; i < arrOne.Length; i++)
                {
                    arrResult[i] = arrOne[i];
                }
                for (int i = 0; i < arrTwo.Length; i++)
                {
                    if (arrResult[i]+arrTwo[i]>9)
                    {
                        arrResult[i + 1]++;
                        arrResult[i] = arrResult[i] + arrTwo[i] - 10;
                    }
                    else
                    {
                        arrResult[i] = arrResult[i] + arrTwo[i];
                    }
                }
                arrResult = CheckForOverflow(arrResult);
                return arrResult;
            }
            else
            {
                int[] arrResult = new int[largestArrLenght + 1];
                for (int i = 0; i < arrTwo.Length; i++)
                {
                    arrResult[i] = arrTwo[i];
                }
                for (int i = 0; i < arrOne.Length; i++)
                {
                    if (arrResult[i] + arrOne[i] > 9)
                    {
                        arrResult[i + 1]++;
                        arrResult[i] = arrResult[i] + arrOne[i] - 10;
                    }
                    else
                    {
                        arrResult[i] = arrResult[i] + arrOne[i];
                    }
                }
                arrResult = CheckForOverflow(arrResult);
                return arrResult;
            }
        }
        static int[] CheckForOverflow(int[] arr)
        {
            for (int i = 0; i < arr.Length-1; i++)
            {
                if (arr[i]>9)
                {
                    arr[i + 1] = arr[i + 1] + 1;
                    arr[i] = arr[i] - 10;
                }
            }
            return arr;
        }
    }
}
