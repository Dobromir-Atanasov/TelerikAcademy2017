using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddingPolynominals
{
    class Program
    {
        // Върнахте ме 30 години назад...

        static void Main(string[] args)
        {
            Console.ReadLine();
            int[] firstPolynominal = Console.ReadLine()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();
            int[] secondPolynominal = Console.ReadLine()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();
            int[] result = new int[firstPolynominal.Length];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = firstPolynominal[i] + secondPolynominal[i];
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
