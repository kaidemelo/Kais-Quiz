﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_stuff
{
    class fizzbuzz
    {
        static void fizzbuzzer(string[] args)
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine(i);
                if (i % 3 == 0)
                {
                    Console.WriteLine("fizz");
                }
                if (i % 5 == 0)
                {
                    Console.WriteLine("buzz");
                }
            }
        }
    }
}
