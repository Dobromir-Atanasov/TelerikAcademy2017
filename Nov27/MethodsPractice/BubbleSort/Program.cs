using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrSize = int.Parse(Console.ReadLine());
            int[] arr = Console.ReadLine()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();
            int temp = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                temp = arr[i];
                int elementToSwitch = MaxElementByGivenIndex(arr, i);
                arr[i] = arr[elementToSwitch];
                arr[elementToSwitch] = temp;
            }
            Console.WriteLine(string.Join(" ", arr.Reverse()));
        }
        static int MaxElementByGivenIndex(int[] arr, int index)
        {
            int result = int.MinValue;
            int indexOfResult = 0;
            for (int i = index; i < arr.Length; i++)
            {
                if (result<arr[i])
                {
                    indexOfResult = i;
                    result = arr[i];
                }
            }
            return indexOfResult;
        }
    }
}
