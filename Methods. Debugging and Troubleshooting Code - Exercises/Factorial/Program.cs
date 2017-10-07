using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger factorialFrom = BigInteger.Parse(Console.ReadLine());

            BigInteger factorial = CalculateFactorial(factorialFrom);

            Console.WriteLine(factorial);
        }

        static BigInteger CalculateFactorial(BigInteger number)
        {
            BigInteger output = number;

            for (int i = 1; i < number; i++)
            {
                output *= i;
            }

            return output;
        }
    }
}
