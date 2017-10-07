using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignOfIntegerNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string numberType = PrintIntegerSign(n);

            Console.WriteLine($"The number {n} is {numberType}.");
        }

        static string PrintIntegerSign(int number)
        {
            if (number > 0)
            {
                return "positive";
            }
            else if (number < 0)
            {
                return "negative";
            }

            return "zero";
        }
    }
}