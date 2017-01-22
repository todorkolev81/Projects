using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_0to100_to_Text
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());

            string deset = "";
            string edno = "";
            string teen = "";
            string numWord = "";

            var desetici = num / 10;
            var edinici = num % 10;

            switch (edinici)
            {
                case 0: edno = "zero"; break;
                case 1: edno = "one"; break;
                case 2: edno = "two"; break;
                case 3: edno = "three"; break;
                case 4: edno = "four"; break;
                case 5: edno = "five"; break;
                case 6: edno = "six"; break;
                case 7: edno = "seven"; break;
                case 8: edno = "eight"; break;
                case 9: edno = "nine"; break;
                default: break;
            }
            switch (desetici)
            {
                case 1:
                    {
                        switch (num)
                        {
                            case 10: teen = "ten"; break;
                            case 11: teen = "eleven"; break;
                            case 12: teen = "twelve"; break;
                            case 13: teen = "thirteen"; break;
                            case 14: teen = "fourteen"; break;
                            case 15: teen = "fifteen"; break;
                            case 16: teen = "sixteen"; break;
                            case 17: teen = "seventeen"; break;
                            case 18: teen = "eighteen"; break;
                            case 19: teen = "nineteen"; break;
                            default: break;
                        }; break;
                    }
                case 2: deset = "twenty"; break;
                case 3: deset = "thirty"; break;
                case 4: deset = "fourty"; break;
                case 5: deset = "fifty"; break;
                case 6: deset = "sixty"; break;
                case 7: deset = "seventy"; break;
                case 8: deset = "eighty"; break;
                case 9: deset = "ninety"; break;
                default: break;
            }
            if (num >= 0 && num <= 99)
            {
                if (num >= 0 && num <= 9)
                {
                    numWord = edno;
                }
                else if (num >= 10 && num <= 19)
                {
                    numWord = teen;
                }
                else if (num >= 20 && num <= 99)
                {
                    if (edinici == 0)
                    { numWord = deset; }
                    else { numWord = deset + " " + edno; }
                }
                Console.WriteLine(numWord);
            }
            else if (num == 100)
            {
                Console.WriteLine("one hundred");
            }
            else
            {
                Console.WriteLine("invalid number");
            }

        }
    }
}



