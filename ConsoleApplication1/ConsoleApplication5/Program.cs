using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBeep
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Beep(432, 500);
            for (int i = 200; i <= 4000; i += 100)
                Console.Beep(i, 100);
        }
        
    }
    }
