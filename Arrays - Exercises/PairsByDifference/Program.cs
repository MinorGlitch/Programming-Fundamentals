using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairsByDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int difference = int.Parse(Console.ReadLine());

            int diffCount = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = numbers.Length - 1; j > i; j--)
                {
                    if (Math.Abs(numbers[i] - numbers[j]) == difference)
                    {
                        diffCount++;
                    }
                }
            }

            Console.WriteLine(diffCount);
        }
    }
}
