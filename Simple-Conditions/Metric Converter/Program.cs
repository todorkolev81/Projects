using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputnum = double.Parse(Console.ReadLine());
            var input = Console.ReadLine().ToLower();
            var output = Console.ReadLine().ToLower();

            var meters = 0d;

            if (input == "mm")
            {
                meters = inputnum / 1000;
            }
            else if (input == "cm")
            {
                meters = inputnum / 100;
            }
            else if (input == "mi")
            {
                meters = inputnum / 0.000621371192;
            }
            else if (input == "in")
            {
                meters = inputnum / 39.3700787;
            }
            else if (input == "km")
            {
                meters = inputnum / 0.001;
            }
            else if (input == "ft")
            {
                meters = inputnum / 3.2808399;
            }
            else if (input == "yd")
            {
                meters = inputnum / 1.0936133;
            }
            else if (input == "m")
            {
                meters = inputnum;
            }

            var outputnum = 0d;

            if (output == "mm")
            {
                outputnum = meters * 1000;
            }
            else if (output == "cm")
            {
                outputnum = meters * 100;
            }
            else if (output == "mi")
            {
                outputnum = meters * 0.000621371192;
            }
            else if (output == "in")
            {
                outputnum = meters * 39.3700787;
            }
            else if (output == "km")
            {
                outputnum = meters * 0.001;
            }
            else if (output == "ft")
            {
                outputnum = meters * 3.2808399;
            }
            else if (output == "yd")
            {
                outputnum = meters * 1.0936133;
            }
            else if (output == "m")
            {
                outputnum = meters;
            }
            Console.WriteLine(outputnum + " " + output);
        }
    }
}
