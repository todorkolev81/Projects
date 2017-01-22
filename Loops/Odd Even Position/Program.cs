using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var oddSum = 0.0;
            var oddMin = 10000000000000.0;
            var oddMax = -10000000000000.0;
            var evenSum = 0.0;
            var evenMin = 10000000000000.0;
            var evenMax = -10000000000000.0;
            for (var i = 1; i <= n; i++)
            {
                var num = double.Parse(Console.ReadLine());
                if (i % 2.0 == 0)
                {
                    evenSum += num;
                    if (num < evenMin)
                    {
                        evenMin = num;
                    }
                    if (num > evenMax)
                    {
                        evenMax = num;
                    }
                }
                else
                {
                    oddSum += num;
                    if (num < oddMin)
                    {
                        oddMin = num;
                    }
                    if (num > oddMax)
                    {
                        oddMax = num;
                    }
                }
            }

            Console.WriteLine("OddSum= " + oddSum);
            if (oddSum == 0)
            {
                Console.WriteLine("OddMin=No");
                Console.WriteLine("OddMax=No");
            }
            else
            {
                Console.WriteLine("OddMin= " + oddMin);
                Console.WriteLine("OddMax= " + oddMax);
            }
            Console.WriteLine("EvenSum= " + evenSum);
            if (evenSum == 0)
            {
                Console.WriteLine("EvenMin=No");
                Console.WriteLine("EvenMax=No");
            }
            else
            {
                Console.WriteLine("EvenMin= " + evenMin);
                Console.WriteLine("EvenMax= " + evenMax);
            }

        }
    }
}
