using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Walls
{
	class walls
	{
		static void Main(string[] args)
		{
			int br1 = int.Parse(Console.ReadLine());
			int br2 = int.Parse(Console.ReadLine());
			int br3 = int.Parse(Console.ReadLine());
			int l = int.Parse(Console.ReadLine());
			int numberOfBricks = 0;
			for (int i = 1; i <= l; i++)
			{
				numberOfBricks += i;
			}
			//Console.WriteLine(numberOfBricks);
			long[] bricks = new long[numberOfBricks];
			bricks[0] = br1;
			bricks[1] = br2;
			bricks[2] = br3;
			for (int i = 3; i < numberOfBricks; i++)
			{
				bricks[i] = bricks[i - 1] + bricks[i - 2] + bricks[i - 3];
			}
			int counter = 0;

			for (int i = 1; i <= l; i++)
			{
				for (int j = 0; j < i; j++)
				{
					Console.Write(bricks[counter]);
					if (j != i - 1)
					{
						Console.Write(" ");
					}
					counter++;
				}
				Console.WriteLine();
			}
		}
	}
}