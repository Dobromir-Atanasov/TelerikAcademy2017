using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAExam
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] input = Console.ReadLine()
				.Split(new string[] { ".", "-" }, StringSplitOptions.RemoveEmptyEntries)
				.ToArray();
			string token = string.Empty;
			if (input.Length > 1)
			{
				token = input[0] + input[1];
			}
			else
			{
				token = input[0];
			}
			int result = 0;
			do
			{
				result = 0;
				for (int i = 0; i < token.Length; i++)
				{
					result += int.Parse(token[i].ToString());
				}
				token = result.ToString();
			}
			while (result.ToString().Length > 1);

			Console.WriteLine(result);
		}
	}
}