using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int sequenceLength = 1;

            int bestSequence = 0;

            int number = 0;

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    sequenceLength++;

                    if (sequenceLength > bestSequence)
                    {
                        bestSequence = sequenceLength;
                        number = numbers[i];
                    }
                }
                else
                {
                    sequenceLength = 1;
                }
            }

            if (sequenceLength == 1)
            {
                Console.WriteLine(numbers[0]);
                return;
            }

            for (int i = 0; i < bestSequence; i++)
            {
                Console.Write($"{number} ");
            }
        }
    }
}
