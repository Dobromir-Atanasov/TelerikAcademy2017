using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace LargestAreaInMatrix
{
	class Program
	{
		public static BigInteger result = 0;
		public static int currentRow = 0;
		public static int currentCol = 0;
		public static BigInteger[,] matrix;
		static void Main(string[] args)
		{
			int rows = int.Parse(Console.ReadLine());
			int cols = int.Parse(Console.ReadLine());
			currentRow = rows - 1;
			matrix = new BigInteger[rows, cols];
			FillMatrix(rows, cols, matrix);
			//PrintMatrix(matrix, rows, cols);
			int numberOfMoves = int.Parse(Console.ReadLine());
			int[] moves = Console.ReadLine()
				.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToArray();
			int coeff = Math.Max(rows, cols);
			for (int i = 0; i < numberOfMoves; i++)
			{
				int targetRow = moves[i]/coeff;
				int targetCol = moves[i] % coeff;
				MoveToPosition(targetRow, targetCol);
			}
			Console.WriteLine(result);
		}

		private static void MoveToPosition(int targetRow, int targetCol)
		{
			if (currentCol<targetCol)
			{
				for (int i = currentCol; i <= targetCol; i++)
				{
					result += matrix[currentRow, i];
					matrix[currentRow, i] = 0;
					

				}
				currentCol = targetCol;
			}
			else
			{
				for (int i = targetCol; i <= currentCol; i++)
				{
					result += matrix[currentRow, i];
					matrix[currentRow, i] = 0;
				}
				currentCol = targetCol;

			}
			if (currentRow<targetRow)
			{
				for (int i = currentRow; i <= targetRow; i++)
				{
					result += matrix[i,currentCol];
					matrix[i, currentCol] = 0;
				}
				currentRow = targetRow;
			}
			else
			{
				for (int i = targetRow; i <= currentRow; i++)
				{
					result += matrix[i, currentCol];
					matrix[i, currentCol] = 0;
				}
				currentRow = targetRow;
			}
		}

		private static void PrintMatrix(BigInteger[,] matrix, int rows, int cols)
		{
			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < cols; j++)
				{
					Console.Write(matrix[i, j] + " ");
				}
				Console.WriteLine();
			};
		}

		private static void FillMatrix(int rows, int cols, BigInteger[,] matrix)
		{
			for (int row = rows-1; row >=0; row--)
			{
				for (int col = 0; col < cols; col++)
				{
					matrix[row, col] = (BigInteger)(Math.Pow(2, rows-row-1) * Math.Pow(2, col));
				}
			}
		}

	}
}
