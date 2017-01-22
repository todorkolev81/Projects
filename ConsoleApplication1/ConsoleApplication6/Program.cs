using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BGNtoEUR
{
    class Program
    {
        static void Main(string[] args)
        {
            var leva = int.Parse(Console.ReadLine());
            var euro = leva / 1.95583;
            Console.WriteLine("BGN");
            Console.WriteLine(euro);
            Console.WriteLine("EURO");
        }
    }
}
