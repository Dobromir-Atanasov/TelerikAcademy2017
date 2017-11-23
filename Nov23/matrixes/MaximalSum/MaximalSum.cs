using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximalSum
{
	class MaximalSum
	{
		public static int[,] matrix;
		static void Main(string[] args)
		{
			string[] nAndM = Console.ReadLine().Split(' ');
			int n = int.Parse(nAndM[0]);
			int m = int.Parse(nAndM[1]);
			matrix = new int[n, m];
			for (int i = 0; i < n; i++)
			{
				string[] temp = Console.ReadLine().Split(' ');
				for (int j = 0; j < temp.Length; j++)
				{
					matrix[i, j] = int.Parse(temp[j]);
					//Console.Write(matrix[i, j] + " ");
				}
				//Console.WriteLine();
			}
			int maxSum = GetMaxSum(0, 0);
			for (int i = 0; i < n-2; i++)
			{
				for (int j = 0; j < m-2; j++)
				{
					if (GetMaxSum(i,j)>maxSum)
					{
						maxSum = GetMaxSum(i, j);
					}
				}
			}
			Console.WriteLine(maxSum);
		}

		static int GetMaxSum(int i, int j) {
			return matrix[i, j] + matrix[i + 1, j] + matrix[i + 2, j] +
				matrix[i, j + 1] + matrix[i + 1, j + 1] + matrix[i + 2, j + 1] +
				matrix[i, j + 2] + matrix[i + 1, j + 2] + matrix[i + 2, j + 2];
		}
	}
}
