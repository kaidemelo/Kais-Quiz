using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_stuff
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\\Users\We\Documents\Work\sample.txt";
            string data = System.IO.File.ReadAllText(path).ToLower();
            var tlsD = new Dictionary<string, int>();
            var tlsN = 0;

            var count = 0;
            Console.WriteLine("Enter the TLS you want to find");
            string tls = Console.ReadLine();
            for (int i = 0; i < data.Length; i++)
            {
                if (data.Substring(i, 3).Equals(tls))
                {
                    count = count + 1;
                    tlsN = tlsN + 1;
                }
                count = count + 1;
            }
            Console.WriteLine("There were " & tlsN & " instances of the TLS : " & tls);










        }
    }
}
