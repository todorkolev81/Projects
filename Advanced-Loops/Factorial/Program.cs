using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = long.Parse(Console.ReadLine());
            long fact = 1;
            while (n > 1)
            {
                fact = fact * n;
                n--;
            } 
            Console.WriteLine(fact);
        }
    }
}
