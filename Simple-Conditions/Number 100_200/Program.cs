﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_100_200
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputnum = int.Parse(Console.ReadLine());

            if (inputnum < 100)
            {
                Console.WriteLine("Less than 100");
            }

            else if (inputnum <= 200)
            {
                Console.WriteLine("Between 100 and 200");
            }
            else
                Console.WriteLine("Greater than 200");
        }
    }
}
