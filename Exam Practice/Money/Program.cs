using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    class Program
    {
        static void Main(string[] args)
        {
            int bitcoin = int.Parse(Console.ReadLine());
            double uan = double.Parse(Console.ReadLine());
            double comision = double.Parse(Console.ReadLine());


            double bitcoinleva = bitcoin * 1168;
            double uanindolar = uan * 0.15;
            double dolarinlv = uanindolar * 1.76;
            double euro = 1.95;

            double lv = bitcoinleva + dolarinlv;
            double comis = (lv / euro) * (comision/100);
            double endresult = (lv / euro) - comis;
            Console.WriteLine(endresult);
        }
    }
}
