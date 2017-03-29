using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformaFizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {

            ICalculation calculation = new Calculation();

            for (var i = 1; i <= 20; i++)
            {
              Console.WriteLine(calculation.DisplayNumber(i));
            }
        }
    }
}
