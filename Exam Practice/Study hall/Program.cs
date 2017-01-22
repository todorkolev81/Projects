using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_hall
{
    class Program
    {
        static void Main(string[] args)
        {
            var h = Double.Parse(Console.ReadLine());
            var w = Double.Parse(Console.ReadLine());
            var hcm = h * 100;
            var wcm = w * 100;
            var hmesta = Math.Floor(hcm / 120);
            var wmesta = Math.Floor((wcm-100) / 70);
            Console.WriteLine((hmesta*wmesta)-3);
        }
    }
}
