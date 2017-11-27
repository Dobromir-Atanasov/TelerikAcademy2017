using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargerThanNeighbours
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
            int[] arr = Console.ReadLine()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int conter = -1;
            for (int i = 1; i < arr.Length - 1; i++)
            {
                if (CheckNeighbours(i, arr))
                {
                    conter = i;
                    break;
                }
            }
            Console.WriteLine(conter);
        }
        static bool CheckNeighbours(int position, int[] arr)
        {
            if (arr[position - 1] < arr[position] && arr[position + 1] < arr[position])
            {
                return true;
            }
            return false;
        }
    }
}
