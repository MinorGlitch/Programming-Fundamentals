using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace FactorialTrailingZeros
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger factorialFrom = BigInteger.Parse(Console.ReadLine());

            BigInteger factorial = CalculateFactorial(factorialFrom);

            int trailingZeros = CalculateTrailingZeros(factorial);

            Console.WriteLine(trailingZeros);
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

        static int CalculateTrailingZeros(BigInteger number)
        {
            BigInteger lastDigit = 0;

            int zerosCount = 0;

            while (lastDigit == 0)
            {
                lastDigit = number % 10;
                zerosCount++;
                number /= 10;
            }

            return zerosCount - 1;
        }
    }
}
