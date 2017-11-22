using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace crookedStairs
{
	class crookedStairs
	{
		static void Main(string[] args)
		{
			BigInteger[] tokenInput = Console.ReadLine()
				 .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
				 .Select(BigInteger.Parse)
				 .ToArray();
			long[] diffs = new long[tokenInput.Length - 1];
			//Console.WriteLine(string.Join(" ", tokenInput));
			for (int i = 0; i < diffs.Length; i++)
			{
				diffs[i] = Math.Abs((long)tokenInput[i] - (long)tokenInput[i + 1]);
			}
			//Console.WriteLine(string.Join(" ", diffs));
			long result = 0;
			for (int i = 0; i < diffs.Length; i++)
			{
				if (diffs[i] % 2 == 0)
				{
					if (i + 1 < diffs.Length)
					{
						diffs[i + 1] = 0;
						i++;
					}
				}
			}
			for (int i = 0; i < diffs.Length; i++)
			{
				if (diffs[i] % 2 == 0)
				{
					result += diffs[i];
				}
			}
			//if (diffs.Length==1&&diffs[0]%2==0)
			//{
			//    result = diffs[0];
			//}
			//for (int i = 0; i < diffs.Length-1; i++)//warning!~!!
			//{
			//    if (diffs[i]%2==0)
			//    {
			//        diffs[i + 1] = 0;
			//        if (diffs[i] % 2 == 0)
			//        {
			//            result += diffs[i];
			//        }

			//        i++;
			//    }
			//}
			Console.WriteLine(result);
		}
	}
}
