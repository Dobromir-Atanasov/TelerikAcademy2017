using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    class gsmTest
    {
        public static void Test()
        {
            GSM[] gsmArr = new GSM[3] { GSM.iphone4s, GSM.iphone4s, GSM.iphone4s };
            gsmArr[1].Owner = "Ivan";
            gsmArr[2].Owner = "Petkan";
            foreach (var gsm in gsmArr)
            {
                Console.WriteLine(gsm.ToString());
            }
        }
    }
}
