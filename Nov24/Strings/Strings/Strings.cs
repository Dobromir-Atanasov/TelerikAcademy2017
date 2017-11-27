using System;

public class Program
{
	public static void Main()
	{
		string text = "Telerik Academy";
		string text1 = "Telerik academy";
		Console.WriteLine("Equality with ==: " + text == text1);
		Console.WriteLine("Equals(): " + text.Equals(text1));
		Console.WriteLine("Equals() ignore case: " + text.Equals(text1, StringComparison.CurrentCultureIgnoreCase));
		Console.WriteLine("Compare(): " + string.Compare(text, text1, false));
		Console.WriteLine("Compare() ignore case: " + string.Compare(text, text1, true));
		Console.WriteLine("IndexOf() found: " + text.IndexOf('T'));
		Console.WriteLine("IndexOf() NOT found: " + text.IndexOf('t'));

		var splitSymbols = new char[] { ' ', ',' };

		// ["Telerik", "Academy"]
		string[] arr = text.Split(splitSymbols, StringSplitOptions.RemoveEmptyEntries);
		Console.WriteLine("Length of the array: " + arr.Length);
		Console.WriteLine("Print array elements with string.Join(): " + string.Join(", ", arr));
	}
}

//False
//Equals(): False
//Equals() ignore case: True
//Compare(): 1
//Compare() ignore case: 0
//IndexOf() found: 0
//IndexOf() NOT found: -1
//Length of the array: 2
//Print array elements with string.Join(): Telerik, Academy
