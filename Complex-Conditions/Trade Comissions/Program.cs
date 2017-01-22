﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trade_Comissions
{
    class Program
    {
        static void Main(string[] args)
        {
            var town = Console.ReadLine().ToLower();
            var sales = double.Parse(Console.ReadLine());
            var comission = -1.0;

            if (sales >= 0 && sales <= 500)
            {
                if (town == "sofia")
                {
                    comission = 0.05;
                }
                else if (town == "varna")
                {
                    comission = 0.045;
                }
                else if (town == "plovdiv")
                {
                    comission = 0.055;
                }
            }
            if (sales > 500 && sales <= 1000)
            {
                if (town == "sofia")
                {
                    comission = 0.07;
                }
                else if (town == "varna")
                {
                    comission = 0.075;
                }
                else if (town == "plovdiv")
                {
                    comission = 0.08;
                }
            }
            if (sales > 1000 && sales <= 10000)
            {
                if (town == "sofia")
                {
                    comission = 0.08;
                }
                else if (town == "varna")
                {
                    comission = 0.1;
                }
                else if (town == "plovdiv")
                {
                    comission = 0.12;
                }
            }
            if (sales >10000)
            {
                if (town == "sofia")
                {
                    comission = 0.12;
                }
                else if (town == "varna")
                {
                    comission = 0.13;
                }
                else if (town == "plovdiv")
                {
                    comission = 0.145;
                }
            }
            if (comission>0)
            {
                Console.WriteLine("{0:f2}",sales*comission);
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
