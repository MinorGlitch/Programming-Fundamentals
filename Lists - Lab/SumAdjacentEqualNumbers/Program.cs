using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumAdjacentEqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            SumNumberSequence(numbers);

            Console.WriteLine(String.Join(" ", numbers));
        }

        static void SumNumberSequence(List<double> numbers)
        {
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                while (numbers[i] == numbers[i + 1])
                {
                    double sum = numbers[i] + numbers[i + 1];

                    numbers.RemoveRange(i, 2);
                    numbers.Insert(i, sum);
                    i = 0;

                    if (numbers.Count < 2)
                    {
                        break;
                    }
                }
            }
        }
    }
}
