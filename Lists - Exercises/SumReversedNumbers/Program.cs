using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumReversedNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int sum = SumNumbers(numbers);

            Console.WriteLine(sum);
        }

        static int SumNumbers(int[] numbers)
        {
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int reversedNum = 0;

                while (numbers[i] > 0)
                {
                    int currentNum = numbers[i] % 10;

                    reversedNum = reversedNum * 10 + currentNum;

                    numbers[i] /= 10;
                }

                sum += reversedNum;
            }

            return sum;
        }
    }
}
