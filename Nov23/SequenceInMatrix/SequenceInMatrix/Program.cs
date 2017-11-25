using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequenceInMatrix
{
    class Program
    {
        public static int[,] matrix;
        static void Main(string[] args)
        {
            string[] tokenInput = Console.ReadLine().Split(' ');
            matrix = new int[int.Parse(tokenInput[0]), int.Parse(tokenInput[1])];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                tokenInput = Console.ReadLine().Split(' ');
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = int.Parse(tokenInput[j]);
                }
            }
            int longestChain = 0;


            //PrintMatrix();
            //Console.ReadKey();
        }
        static void PrintMatrix()
        {
            for (int i = 0; i < matrix.GetLength(0) ; i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
