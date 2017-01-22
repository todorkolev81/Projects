using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            var kind = Console.ReadLine();

            if (kind == "square")
            {
                var ar = double.Parse(Console.ReadLine());
                Console.WriteLine(ar * ar);
            }
            else if (kind == "rectangle")
            {
                var ar = double.Parse(Console.ReadLine());
                var bh = double.Parse(Console.ReadLine());
                Console.WriteLine(ar * bh);
            }
            else if (kind == "triangle")
            {
                var ar = double.Parse(Console.ReadLine());
                var bh = double.Parse(Console.ReadLine());
                Console.WriteLine(ar * bh / 2);
            }
            else if (kind == "circle")
            {
                var ar = double.Parse(Console.ReadLine());

                Console.WriteLine(Math.PI * ar * ar);
            }
        }
    }
}
