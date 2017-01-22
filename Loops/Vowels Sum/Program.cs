using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vowels_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            //var text = Console.ReadLine();
            //var sum = 0;
            //for (int i = 0; i < text.Length; i++)
            //{
            //    if (text[i] == 'a')
            //    {
            //        sum += 1;
            //    }
            //    else if (text[i] == 'e')
            //    {
            //        sum += 2;
            //    }
            //    else if (text[i] == 'i')
            //    {
            //        sum += 3;
            //    }
            //    else if (text[i] == 'o')
            //    {
            //        sum += 4;
            //    }
            //    else if (text[i] == 'u')
            //    {
            //        sum += 5;
            //    }
            //}
            //Console.WriteLine("Vowels sum = " + sum);

            string text = Console.ReadLine();
            int sum = 0;
            for (int i = 0; i < text.Length; i++)
            {
                switch (text[i])
                {
                    case 'a':sum += 1;break;
                    case 'e': sum += 2; break;
                    case 'i': sum += 3; break;
                    case 'o': sum += 4; break;
                    case 'u': sum += 5; break;
                    default:break;
                }

            }
            Console.WriteLine(sum);

        }
    }
}
