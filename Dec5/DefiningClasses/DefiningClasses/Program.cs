using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Defining Classes - Part 1
// Implemented Problems 1 to 7
// 5 to go...

namespace DefiningClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            GSM myPhone = new GSM("S6Edge", "Samsung", 100, "Pesho", new Battery("test"), new Display(10,10));
            Console.WriteLine(myPhone.ToString());
            gsmTest.Test();
        }
    }
}
