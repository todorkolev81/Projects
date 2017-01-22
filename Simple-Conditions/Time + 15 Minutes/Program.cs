using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time___15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            var h = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var min15 = m + 15;
            var mins = (m + 15) % 60;

            if (min15 >= 60)
            {
                h += 1;
            }

            if (h >= 24)
            {
                h -= 24;
            }

            if (mins < 10)
            {
                Console.WriteLine(h + ":0" + mins);
            }
            else if (mins <= 59)
            {
                Console.WriteLine(h + ":" + mins);
            }
        }
    }
}
