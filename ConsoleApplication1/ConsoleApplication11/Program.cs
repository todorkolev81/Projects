using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christmas_TreeNEW
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            string pipe = " | ";
            string space = new string(' ', n);
            Console.WriteLine(space + pipe);

            for (int i = 0; i < n; i++)
            {
                Console.Write(new string(' ', n - i - 1));
                Console.Write(new string('*', i + 1));
                Console.Write(pipe);
                Console.WriteLine(new string('*', i + 1));
            }

        }
    }
}
