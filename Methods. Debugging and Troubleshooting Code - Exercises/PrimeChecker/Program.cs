using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {

            long number = long.Parse(Console.ReadLine());

            bool isPrime = IsPrime(number);

            Console.WriteLine(isPrime);
        }

        static bool IsPrime(long num)
        {
            bool checkPrime = true;

            if (num < 2)
            {
                checkPrime = false;
                return checkPrime;
            }

            for (long i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    checkPrime = false;
                    break;
                }
            }

            return checkPrime;
        }
    }
}
