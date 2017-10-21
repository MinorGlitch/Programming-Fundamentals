using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            File.WriteAllText("input.txt", String.Empty);

            //Replace String.Empty with your input arguments.

            string inputSequence = File.ReadAllText("input.txt");

            int[] numberSequence = inputSequence.Split(' ').Select(int.Parse).ToArray();

            int sequenceLength = 1;

            int bestStart = 0;
            int bestSequence = 0;

            bool isBest = false;

            File.WriteAllText("output.txt", String.Empty);

            for (int i = 1; i <= numberSequence.Length - 1; i++)
            {
                int sequenceStart = i;

                if (numberSequence[i] == numberSequence[i - 1])
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

            for (int i = bestStart; i > bestStart - bestSequence; i--)
            {
                string currentOutput = $"{numberSequence[i]} ";

                File.AppendAllText("output.txt", currentOutput);
            }
        }
    }
}
