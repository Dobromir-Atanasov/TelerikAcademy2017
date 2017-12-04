using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{

	class Battleship
	{
		static int[,] boardOne;
		static int[,] boardTwo;

		static void Main(string[] args)
		{
			int[] boardSize = Console.ReadLine()
				.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToArray();
			boardOne = new int[boardSize[0], boardSize[1]];
			boardTwo = new int[boardSize[0], boardSize[1]];
			FillBoards();
			//PrintBoards();
			string[] tokenInput = Console.ReadLine()
				.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
				.ToArray();
			while (tokenInput[0]!="END")
			{
				if (tokenInput[0]=="P2")
				{
					CheckThePlay(boardOne, int.Parse(tokenInput[1]), int.Parse(tokenInput[2]));
				}
				else
				{
					CheckThePlay(boardTwo, int.Parse(tokenInput[1]), int.Parse(tokenInput[2]));
				}
				tokenInput = Console.ReadLine()
						.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
						.ToArray();
			}
			Console.WriteLine("{0}:{1}", GetResult(boardOne),GetResult(boardTwo));
		}

		public static int GetResult(int[,] board)
		{
			int result = 0;
			for (int i = 0; i < board.GetLength(0); i++)
			{
				for (int j = 0; j < board.GetLength(1); j++)
				{
					if (board[i,j]==1)
					{
						result++;
					}
				}
			}
			return result;
		}

		private static void CheckThePlay(int[,] board, int row, int col)
		{
			if (board[row,col]==-1)
			{
				Console.WriteLine("Try again!");
			}
			else if (board[row,col]==1)
			{
				Console.WriteLine("Booom");
				board[row, col] = -1;
			}
			else if (board[row,col]==0)
			{
				Console.WriteLine("Missed");
				board[row, col] = -1;
			}
		}

		private static void PrintBoards()
		{
			for (int i = 0; i < boardOne.GetLength(0); i++)
			{
				for (int j = 0; j < boardOne.GetLength(1); j++)
				{
					Console.Write(boardOne[i, j] + " ");
				}
				Console.WriteLine();
			}
			for (int i = 0; i < boardTwo.GetLength(0); i++)
			{
				for (int j = 0; j < boardTwo.GetLength(1); j++)
				{
					Console.Write(boardTwo[i, j] + " ");
				}
				Console.WriteLine();
			}
		}

		private static void FillBoards()
		{
			for (int i = 0; i < boardOne.GetLength(0);i ++)
			{
				string[] tokenInput= Console.ReadLine()
					.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
					.ToArray();

				for (int j = 0; j < tokenInput.Length; j++)
				{
					boardOne[i, j] = int.Parse(tokenInput[j]);
				}
			}
			for (int i = boardTwo.GetLength(0)-1; i >=0; i--)
			{
				string[] tokenInput = Console.ReadLine()
					.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
					.ToArray();

				for (int j = 0; j < tokenInput.Length; j++)
				{
					boardTwo[i, j] = int.Parse(tokenInput[j]);
				}
			}
		}
	}
}
