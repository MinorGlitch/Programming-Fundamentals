using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripleSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            GenerateCombination(numbers);
        }

        static void GenerateCombination(int[] numbers)
        {
            bool containsMatch = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    int a = numbers[i];
                    int b = numbers[j];

                    int lastSum = a + b;

                    if (numbers.Contains(lastSum))
                    {
                        containsMatch = true;
                        Console.WriteLine($"{a} + {b} == {lastSum}");
                    }
                }
            }

            if (!containsMatch)
            {
                Console.WriteLine($"No");
            }
        }
    }
}
