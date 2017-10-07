using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            double result = CalculatePower(number, power);

            Console.WriteLine(result);
        }

        static double CalculatePower(double number, int power)
        {
            double result = 1d;

            for (int i = 0; i < power; i++)
            {
                result *= number;
            }
            return result;
        }
    }
}
