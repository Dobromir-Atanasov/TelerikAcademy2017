using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseURL
{
    class Program
    {
        static void Main(string[] args)
        {
            string protocol = string.Empty;
            string server = string.Empty;
            string resource = string.Empty;
            string[] tokenInput = Console.ReadLine().Split(new[] { "://" }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            protocol = tokenInput[0];
            int indexOfSlash = tokenInput[1].IndexOf('/');
            server = tokenInput[1].Substring(0, indexOfSlash);
            resource = tokenInput[1].Substring(indexOfSlash);
            Console.WriteLine("[protocol] = {0}", protocol);
            Console.WriteLine("[server] = {0}", server);
            Console.WriteLine("[resource] = {0}", resource);
        }
    }
}
