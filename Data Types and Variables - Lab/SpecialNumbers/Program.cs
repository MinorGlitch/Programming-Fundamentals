using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                int lastNum = i;

                int sumOfDigits = 0;

                while (lastNum > 0)
                {
                    sumOfDigits += lastNum % 10;
                    lastNum = lastNum / 10;
                }

                bool isSpecial = sumOfDigits == 5 || sumOfDigits == 7 || sumOfDigits == 11;

                Console.WriteLine($"{i} -> {isSpecial}");
            }
        }
    }
}
