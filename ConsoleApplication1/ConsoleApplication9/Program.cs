using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_of_Stars
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
                        
            string star = "*";
            string space = new string(' ', n - 2);
            string starn = new string('*', n);
            Console.WriteLine(starn);
            for (int i = 0; i < n-2; i++)
            {
                Console.WriteLine(star+space+star);
            }
            

            Console.WriteLine(starn);
            
        }
    }
}
