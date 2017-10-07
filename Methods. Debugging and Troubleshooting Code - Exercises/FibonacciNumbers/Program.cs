using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            Console.WriteLine(GetFibonacciNumber(input));
        }

        static int GetFibonacciNumber(double getFromNumber)
        {
            int a = 0;
            int b = 1;

            for (int i = 1; i <= getFromNumber + 1; i++)
            {
                int previousNum = a;
                a = b;
                b = previousNum + b;
            }

            return a;
        }
    }
}
