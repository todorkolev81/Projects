using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            var typeY = Console.ReadLine();
            //брой празници в годината (които не са събота и неделя). 
            var p = int.Parse(Console.ReadLine());
            //брой уикенди, в които Влади си пътува до родния град.
            var h = int.Parse(Console.ReadLine());
            var calcs = -1.0;
            if (typeY == "normal")
            {
                calcs = ((48 - h) * (3.0 / 4)) + h + (p * 2.0 / 3);
            }
            else if (typeY == "leap")
            {
                calcs = (((48 - h) * (3.0 / 4)) + h + (p * 2.0 / 3)) + 
                    (((48 - h) * (3.0 / 4)) + h + (p * 2.0 / 3)) * 0.15;
            }

            if (calcs > 0)
            {
                Console.WriteLine(Math.Truncate(calcs));
            }
        }
    }
}
