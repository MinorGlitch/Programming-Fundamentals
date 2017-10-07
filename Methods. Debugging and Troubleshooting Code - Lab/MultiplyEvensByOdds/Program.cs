using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            number = Math.Abs(number);

            int totalSum = GetSumOfOddAndEvenDigits(number);

            Console.WriteLine(totalSum);
        }

        static int GetSumOfOddAndEvenDigits(int number)
        {
            int sumOfEvens = getSumOfEvenDigits(number);
            int sumOfOdds = getSumOfOddDigits(number);

            return sumOfEvens * sumOfOdds;
        }

        static int getSumOfEvenDigits(int number)
        {
            int sum = 0;

            while (number > 0)
            {
                int lastDigit = number % 10;

                if (lastDigit % 2 == 0)
                {
                    sum += lastDigit;
                }

                number /= 10;
            }

            return sum;
        }

        static int getSumOfOddDigits(int number)
        {
            int sum = 0;

            while (number > 0)
            {
                int lastDigit = number % 10;

                if (lastDigit % 2 != 0)
                {
                    sum += lastDigit;
                }

                number /= 10;
            }

            return sum;
        }
    }
}
