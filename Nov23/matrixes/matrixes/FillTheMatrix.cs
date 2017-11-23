using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrixes
{
	class FillTheMatrix
	{
		public static int[,] matrix;
		public static int mSize;
		static void Main(string[] args)
		{
			mSize = int.Parse(Console.ReadLine());
			string fillType = Console.ReadLine();

			matrix = new int[mSize, mSize];
			switch (fillType)
			{
				case "a":
					CaseA();
					break;
				case "b":
					CaseB();
					break;
				case "c":
					CaseC();
					break;
				case "d":
					CaseD();
					break;
				default:
					break;
			}
			if (fillType != "d")
			{
				PrintMatrix();
			}
		}

		static void CaseC()
		{
			//implement
		}
		static void PrintMatrix()
		{
			for (int i = 0; i < mSize; i++)
			{
				for (int j = 0; j < mSize; j++)
				{
					Console.Write(matrix[i, j]);
					if (j != mSize - 1)
					{
						Console.Write(" ");
					}
				}
				Console.WriteLine();
			}
		}

		static void CaseD()
		{
			int n = mSize;

			int k = 1, c1 = 0, c2 = n - 1, r1 = 0, r2 = n - 1;

			while (k <= n * n)
			{
				for (int i = c1; i <= c2; i++)
				{
					matrix[r1, i] = k++;
				}

				for (int j = r1 + 1; j <= r2; j++)
				{
					matrix[j, c2] = k++;
				}

				for (int i = c2 - 1; i >= c1; i--)
				{
					matrix[r2, i] = k++;
				}

				for (int j = r2 - 1; j >= r1 + 1; j--)
				{
					matrix[j, c1] = k++;
				}

				c1++;
				c2--;
				r1++;
				r2--;
			}
			for (int i = 0; i < mSize; i++)
			{
				for (int j = 0; j < mSize; j++)
				{
					Console.Write(matrix[j, i]);
					if (j != mSize - 1)
					{
						Console.Write(" ");
					}
				}
				Console.WriteLine();
			}
		}

		static void CaseB()
		{
			int counter = 1;
			for (int i = 0; i < mSize; i++)
			{
				if (i % 2 == 0)
				{
					for (int j = 0; j < mSize; j++)
					{
						matrix[j, i] = counter++;
					}
				}
				else
				{
					for (int j = mSize - 1; j >= 0; j--)
					{
						matrix[j, i] = counter++;
					}
				}
			}
		}

		static void CaseA()
		{
			int counter = 1;
			for (int i = 0; i < mSize; i++)
			{
				for (int j = 0; j < mSize; j++)
				{
					matrix[j, i] = counter;
					counter++;
				}
			}
		}
	}
}
