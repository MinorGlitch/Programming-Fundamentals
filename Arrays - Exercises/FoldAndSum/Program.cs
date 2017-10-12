using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int arrayLength = numbers.Length / 4;

            int[] firstRow = CreateFirstRow(numbers, numbers.Length / 2, arrayLength);

            int[] secondRow = CreateSecondRow(numbers, arrayLength);

            int[] summedRow = new int[arrayLength * 2];

            summedRow = SumRows(firstRow, secondRow, summedRow);

            PrintResult(summedRow);
        }

        static void PrintResult(int[] summedRow)
        {
            Console.WriteLine(String.Join(" ", summedRow));
        }

        static int[] SumRows(int[] firstRow, int[] secondRow, int[] summedRow)
        {
            for (int i = 0; i < summedRow.Length; i++)
            {
                summedRow[i] = firstRow[i] + secondRow[i];
            }

            return summedRow;
        }

        static int[] CreateFirstRow(int[] numbers, int arrLength, int numbersLength)
        {
            int rowIndex = 0;

            int[] firstRow = new int[arrLength];

            for (int i = numbersLength - 1; i >= 0; i--)
            {
                firstRow[rowIndex] = numbers[i];
                rowIndex++;
            }

            for (int i = numbers.Length - 1; i > (numbers.Length - 1) - numbersLength; i--)
            {
                firstRow[rowIndex] = numbers[i];
                rowIndex++;
            }

            return firstRow;
        }

        static int[] CreateSecondRow(int[] numbers, int arrLength)
        {
            int rowIndex = 0;

            int[] secondRow = new int[arrLength * 2];

            for (int i = arrLength; i < numbers.Length - arrLength; i++)
            {
                secondRow[rowIndex] = numbers[i];
                rowIndex++;
            }

            return secondRow;
        }
    }
}
