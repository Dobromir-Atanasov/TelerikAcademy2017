using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
	class SendMeTheCode
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			if (input[0]=='-')
			{
				input = input.Substring(1);
			}
			int[] inputDigits = new int[input.Length];
			for (int i = 0; i < input.Length; i++)
			{
				inputDigits[i] = int.Parse(input[i].ToString());
				//Console.WriteLine(inputDigits[i]);
			}
			inputDigits = inputDigits.Reverse().ToArray();
			long result = 0;
			for (int i = 1; i <= inputDigits.Length; i++)
			{
				if (i%2!=0)
				{
					result += inputDigits[i-1] * (long)Math.Pow(i,2);
				}
				else
				{
					result += (long)Math.Pow(inputDigits[i - 1],2) * i;
				}
			}
			Console.WriteLine(result);
			if (result%10==0)
			{
				Console.WriteLine("Big Vik wins again!");
			}
			else
			{
				long msgLenght = result % 10;
				long s = result % 26+1;
				for (int i = 0; i < msgLenght; i++)
				{
					
					if (s>=27)
					{
						s = 1;
					}
					
					Console.Write((char)(64+s));
					s++;
				}
			}
		}
	}
}
