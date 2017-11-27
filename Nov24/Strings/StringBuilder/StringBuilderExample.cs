using System;
using System.Text;
using System.Diagnostics;

namespace StringBuilderExample

{
	class StringBuilderExample
	{
		static void Main(string[] args)
		{
			int count = 10000;
			string str = string.Empty;
			StringBuilder strBuilder = new StringBuilder();
			Stopwatch sw = Stopwatch.StartNew();

			for (int i = 0; i < count; i++)
			{
				str += i;
			}
			Console.WriteLine($"String concatenate: {sw.ElapsedMilliseconds}"); // ~ 12500 ms
			sw = Stopwatch.StartNew();

			for (int i = 0; i < count; i++)
			{
				strBuilder.Append(i);
			}
			Console.WriteLine($"StringBuilder append: {sw.ElapsedMilliseconds}"); // ~ 10 ms
		}
	}
}
