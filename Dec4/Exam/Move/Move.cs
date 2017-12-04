using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Move
{
	class Move
	{
		public static long fSum = 0;
		public static long bSum = 0;
		public static int position;
		public static int[] arr;

		static void Main(string[] args)
		{
			position = int.Parse(Console.ReadLine());
			arr = Console.ReadLine()
				.Split(new[] { "," }, StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToArray();
			string[] command = Console.ReadLine()
				.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
				.ToArray();
			while (command[0] != "exit")
			{
				int repeats = int.Parse(command[0]);
				int step = int.Parse(command[2])%arr.Length;
				if (command[1] == "forward")
				{
					MoveForward(repeats, step);
				}
				else
				{
					MoveBackward(repeats, step);
				}
				command = Console.ReadLine()
					.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
					.ToArray();
			}
			Console.WriteLine("Forward: {0}",fSum);
			Console.WriteLine("Backwards: {0}",bSum);
		}

		private static void MoveBackward(int repeats, int step)
		{
			for (int i = 0; i < repeats; i++)
			{
				position -= step;
				if (position < 0)
				{
					position += arr.Length;
				}
				bSum += arr[position];

			}
		}

		private static void MoveForward(int repeats, int step)
		{
			for (int i = 0; i < repeats; i++)
			{
				position += step;
				if (position > arr.Length - 1)
				{
					position -=arr.Length;
				}
				fSum += arr[position];
			}
		}
	}
}
