using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            PrintRoundedNumbers(numbers);
        }

        static void PrintRoundedNumbers(double[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                double currentNum = numbers[i];

                Console.WriteLine($"{numbers[i]} => {Math.Round(currentNum, MidpointRounding.AwayFromZero)}");
            }
        }
    }
}
