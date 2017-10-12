using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSequenceOfIncreasingElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numberSequence = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int sequenceLength = 1;

            int bestStart = 0;
            int bestSequence = 0;

            bool isBest = false;

            for (int i = 1; i <= numberSequence.Length - 1; i++)
            {
                int sequenceStart = i;

                if (numberSequence[i] > numberSequence[i - 1])
                {
                    sequenceLength++;

                    if (isBest == false)
                    {
                        bestStart = sequenceStart;
                        bestSequence = sequenceLength;

                        isBest = true;
                    }

                    if (sequenceLength > bestSequence)
                    {
                        bestStart = sequenceStart;
                        bestSequence = sequenceLength;
                    }
                }
                else
                {
                    i = sequenceStart;
                    sequenceLength = 1;
                }
            }

            List<int> finalNumbers = new List<int>();

            for (int i = bestStart; i > bestStart - bestSequence; i--)
            {
                finalNumbers.Add(numberSequence[i]);
            }

            finalNumbers.Reverse();

            Console.WriteLine(String.Join(" ", finalNumbers));
        }
    }
}
