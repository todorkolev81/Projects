using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter score: ");
            var num = int.Parse(Console.ReadLine());
            var bonuspoints = 0.0;
            if (num <= 100)
                bonuspoints += 5;
            else if (num < 1000)
            {
                bonuspoints = num * 0.20;
            }
            else if (num > 1000)
            {
                bonuspoints = num * 0.10;
            }
            if (num % 2 == 0)
                bonuspoints += 1;
            if (num % 10 == 5)
                bonuspoints += 2;


            Console.WriteLine(bonuspoints);
            Console.WriteLine(num + bonuspoints);

        }
    }
}
