using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            var amount = double.Parse(Console.ReadLine());
            var currencyFrom = Console.ReadLine().ToUpper();
            var currencyTo = Console.ReadLine().ToUpper();
            //var BGN = 1;
            //var USD = 1.79549;
            //var EUR = 1.95583;
            //var GBP = 2.53405;

            var leva = 0d;

            if (currencyFrom == "USD")
            {
                leva = amount * 1.79549;
            }
            else if (currencyFrom == "EUR")
            {
                leva = amount * 1.95583;
            }
            else if (currencyFrom == "GBP")
            {
                leva = amount * 2.53405;
            }
            else if (currencyFrom == "BGN")
            {
                leva = amount;
            }

            var outputcur = 0d;

            if (currencyTo == "USD")
            {
                outputcur = leva / 1.79549;
            }
            else if (currencyTo == "EUR")
            {
                outputcur = leva / 1.95583;
            }
            else if (currencyTo == "GBP")
            {
                outputcur = leva / 2.53405;
            }
            else if (currencyTo == "BGN")
            {
                outputcur = leva;
            }
            Console.WriteLine(Math.Round(outputcur,2) + " " + currencyTo);
        }

    }
}
