using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitty
{
	class Program
	{
		public static int soulsCounter = 0;
		public static int foodCounter = 0;
		public static int deadlockCounter = 0;
		public static char[] maze;
		public static int[] moves;
		public static int currentPosition = 0;
		public static int jumps = 0;
		public static bool exitTime = false;

		static void Main(string[] args)
		{
			maze = Console.ReadLine()
				.ToCharArray();
			moves = Console.ReadLine()
				.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToArray();
			CheckPosition(currentPosition);
			for (int move = 0; move < moves.Length; move++)
			{
				if (exitTime)
				{
					Console.WriteLine("You are deadlocked, you greedy kitty!");
					Console.WriteLine("Jumps before deadlock: {0}", jumps);
					break;
				}
				jumps++;

				//COMENT ME
				//PrintStats();
				if (moveToRight(move))
				{
					currentPosition+=moves[move]%maze.Length;
					if (currentPosition>maze.Length-1)
					{
						currentPosition -= maze.Length;
					}
				}
				else
				{
					currentPosition+=moves[move]%maze.Length; //we add again since number is negative
					if (currentPosition<0)
					{
						currentPosition += maze.Length;
					}
				}
				CheckPosition(currentPosition);
				if (exitTime)
				{
					Console.WriteLine("You are deadlocked, you greedy kitty!");
					Console.WriteLine("Jumps before deadlock: {0}", jumps);
					break;
				}
			}
			if (!exitTime)
			{
				PrintStats();
			}
		}

		private static bool moveToRight(int move)
		{
			return moves[move] >= 0 ? true : false;
		}

		static void CheckPosition(int position)
		{
			char posElement = maze[position];
			if (posElement == '@')
			{
				soulsCounter++;
				maze[position] = 'N';
				return;
			}
			if (posElement == '*')
			{
				foodCounter++;
				maze[position] = 'N';
				return;
			}
			if (posElement == 'x')
			{
				DeadTrap(position);
				return;
			}
			if (posElement == 'N')
			{
				return;
			}
		}
		public static void PrintStats()
		{
			Console.WriteLine("Coder souls collected: {0}", soulsCounter);
			Console.WriteLine("Food collected: {0}", foodCounter);
			Console.WriteLine("Deadlocks: {0}", deadlockCounter);
			//FOR TEST ONLY!!!
			//PrintMaze();
		}

		public static void PrintMaze()
		{
			Console.WriteLine(string.Join(" ", maze));
			Console.WriteLine("Position {0}", currentPosition);
		}

		private static void DeadTrap(int position)
		{
			deadlockCounter++;
			if (position%2==0)
			{
				//must leave soul
				if (soulsCounter>=1)
				{
					soulsCounter--;
					maze[position] = '@';
				}
				else
				{
					exitTime = true;
				}
			}
			else
			{
				//must leave food
				if (foodCounter >= 1)
				{
					foodCounter--;
					maze[position] = '*';
				}
				else
				{
					exitTime = true;
				}
			};
		}
	}
}
