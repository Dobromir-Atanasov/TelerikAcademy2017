using System;

namespace MethodsPractice
{
    class Program
    {
        static void Main()
        {
            string name = Console.ReadLine();
            PrintHello(name);
        }
        static void PrintHello(string name)
        {
            Console.WriteLine("Hello, {0}!", name);
        }
    }
}
