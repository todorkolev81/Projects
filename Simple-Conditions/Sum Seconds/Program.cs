using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());
            var num3 = int.Parse(Console.ReadLine());
            var totaltime = num1 + num2 + num3;
            var mins = totaltime / 60;
            var sec = totaltime % 60;

            if (sec < 10)
            {
                Console.WriteLine(mins + ":0" + sec);
            }
            else
            {
                Console.WriteLine(mins + ":" + sec);
            }

        }
    }
}

