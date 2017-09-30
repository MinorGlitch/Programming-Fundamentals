using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                int lastNum = i;

                int sum = 0;

                while (lastNum > 0)
                {
                    sum += lastNum % 10;
                    lastNum = lastNum / 10;
                }

                bool isSpecial = (sum == 5) || (sum == 7) || (sum == 11);

                Console.WriteLine($"{i} -> {isSpecial}");
            }
        }
    }
}
