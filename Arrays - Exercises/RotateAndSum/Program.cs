using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int numberOfRotations = int.Parse(Console.ReadLine());

            int[] summedNumbers = RotateArrays(numbers, numberOfRotations);

            Console.WriteLine(String.Join(" ", summedNumbers));
        }

        static int[] RotateArrays(int[] arrayToRotate, int rotations)
        {
            int[] summedNumbers = new int[arrayToRotate.Length];

            bool wasSummed = false;

            for (int i = 0; i < rotations; i++)
            {
                int lastElement = arrayToRotate[arrayToRotate.Length - 1];

                int[] lastRotation = arrayToRotate.Clone() as int[];

                for (int j = arrayToRotate.Length - 1; j >= 1; j--)
                {
                    arrayToRotate[j] = arrayToRotate[j - 1];
                }

                arrayToRotate[0] = lastElement;

                if (i >= 1)
                {
                    if (wasSummed == false)
                    {
                        for (int j = 0; j < arrayToRotate.Length; j++)
                        {
                            summedNumbers[j] = lastRotation[j] + arrayToRotate[j];
                        }
                    }
                    if (wasSummed)
                    {
                        for (int j = 0; j < arrayToRotate.Length; j++)
                        {
                            int[] lastSum = summedNumbers.Clone() as int[];
                            summedNumbers[j] = lastSum[j] + arrayToRotate[j];
                        }
                    }

                    wasSummed = true;
                }
                else if (rotations <= 1)
                {
                    summedNumbers = arrayToRotate;
                }
            }

            return summedNumbers;
        }
    }
}
