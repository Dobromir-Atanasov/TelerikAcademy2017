using System;

namespace BishopPathFinder
{
	public struct Point
	{
		private int v1;
		private int v2;

		public Point(int v1, int v2) : this()
		{
			this.v1 = v1;
			this.v2 = v2;
		}

		public int X { get; set; }
		public int Y { get; set; }
	}

	class BishopPathFinder
	{
		public static bool[,] matrix;
		public static Point currentPosition = new Point(0, 0);
		public static int totalSum = 0;

		static void Main()
		{
			string[] inputToken = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
			int matrixDimRow = int.Parse(inputToken[0]);
			int matrixDimCol = int.Parse(inputToken[1]);
			matrix = new bool[matrixDimRow, matrixDimCol];
			inputToken = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
			int numberOfInputs = int.Parse(inputToken[0]);
			for (int i = 0; i < numberOfInputs; i++)
			{
				inputToken = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
				string direction = inputToken[0];
				int moves = int.Parse(inputToken[1]);

				MakeTheMove(direction, moves);
			}
			Console.WriteLine(totalSum);
		}
		static void MakeTheMove(string direction, int moves)
		{
			moves--;
			if (!matrix[currentPosition.X, currentPosition.Y])
			{
				matrix[currentPosition.X, currentPosition.Y] = true;
				totalSum += CellPower(currentPosition);
			}

		}

		static int CellPower(Point pointToCheck)
		{
			return pointToCheck.X * 3 + pointToCheck.Y * 3;
		}
	}
}