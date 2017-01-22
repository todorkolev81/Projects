using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Small_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = Console.ReadLine().ToLower();
            var town = Console.ReadLine().ToLower();
            var quantity = double.Parse(Console.ReadLine());

            if (product == "coffee")
            {
                if (town == "sofia")
                    Console.WriteLine(0.5 * quantity);
                else if (town == "plovdiv")
                    Console.WriteLine(0.4 * quantity);
                else if (town == "varna")
                    Console.WriteLine(0.45 * quantity);

            }
            if (product == "water")
            {
                if (town == "sofia")
                    Console.WriteLine(0.8 * quantity);
                else if (town == "plovdiv")
                    Console.WriteLine(0.7 * quantity);
                else if (town == "varna")
                    Console.WriteLine(0.7 * quantity);
            }
            if (product == "beer")
            {
                if (town == "sofia")
                    Console.WriteLine(1.2 * quantity);
                else if (town == "plovdiv")
                    Console.WriteLine(1.15 * quantity);
                else if (town == "varna")
                    Console.WriteLine(1.10 * quantity);
            }
            if (product == "sweets")
            {
                if (town == "sofia")
                    Console.WriteLine(1.45 * quantity);
                else if (town == "plovdiv")
                    Console.WriteLine(1.30* quantity);
                else if (town == "varna")
                    Console.WriteLine(1.35 * quantity);
            }
            if (product == "peanuts")
            {
                if (town == "sofia")
                    Console.WriteLine(1.60 * quantity);
                else if (town == "plovdiv")
                    Console.WriteLine(1.50 * quantity);
                else if (town == "varna")
                    Console.WriteLine(1.55 * quantity);
            }
        }
    }
}
