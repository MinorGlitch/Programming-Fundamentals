using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int cycles = int.Parse(Console.ReadLine());

            int oddSum = 0;

            for (int i = 1; i <= cycles; i++)
            {
                Console.WriteLine(2 * i - 1);
                oddSum += i * 2 - 1;
            }

            Console.WriteLine($"Sum: {oddSum}");
        }
    }
}
