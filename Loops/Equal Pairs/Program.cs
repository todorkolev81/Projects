using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equal_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var current = 0;
            var previous = 0;
            var diff = 0;
            var maxdiff = 0;

            for (int i = 0; i < n; i++)
            {
                var num1 = int.Parse(Console.ReadLine());
                var num2 = int.Parse(Console.ReadLine());
                current = previous;
                previous = num1 + num2;
                maxdiff = Math.Abs(previous - current);
                diff = maxdiff;
            }
            if (n < 2 || diff == 0)
            {
                Console.WriteLine("Yes, value={0}", previous);
            }
            else
            {
                Console.WriteLine("No, maxdiff={0}", diff);
            }

        }
    }
}
