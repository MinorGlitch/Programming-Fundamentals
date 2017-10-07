using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                IsMaster(i);
            }
        }

        static void IsMaster(int number)
        {
            bool isSymm = IsSymmetric(number);
            bool isDivisible = IsSumDivisibleBy7(number);
            bool containsEvenDigits = ContainsEvenDigits(number);

            if (isSymm && isDivisible && containsEvenDigits)
            {
                Console.WriteLine(number);
            }
        }

        static bool IsSymmetric(int number)
        {
            int tempNumber = number;
            int reverse = 0;

            while (number > 0)
            {
                int digit = number % 10;
                reverse = reverse * 10 + digit;
                number /= 10;
            }

            if (tempNumber == reverse)
            {
                return true;
            }

            return false;
        }

        static bool ContainsEvenDigits(int number)
        {
            string num = number.ToString();
            char[] numDigits = num.ToCharArray();

            for (int i = 0; i < numDigits.Length; i++)
            {
                if (numDigits[i] % 2 == 0)
                {
                    return true;
                }
            }

            return false;
        }

        static bool IsSumDivisibleBy7(int number)
        {
            int sum = 0;

            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }

            if (sum % 7 == 0)
            {
                return true;
            }

            return false;
        }
    }
}
