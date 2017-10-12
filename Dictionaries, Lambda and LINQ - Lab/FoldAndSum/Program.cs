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
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            int k = numbers.Count / 4;

            int[] firstRow = CreateFirstRow(numbers, k);

            int[] secondRow = CreateSecondRow(numbers, k);

            int[] summedRows = firstRow.Select((x, index) => x + secondRow[index]).ToArray();

            Console.WriteLine(String.Join(" ", summedRows));
        }

        static int[] CreateSecondRow(List<int> numbers, int k)
        {
            int[] secondRow = numbers.Skip(k).Take(2 * k).ToArray();

            return secondRow;
        }

        static int[] CreateFirstRow(List<int> numbers, int k)
        {
            List<int> numbersCopy = new List<int>(numbers);

            int[] leftSide = numbersCopy.Take(k).Reverse().ToArray();

            numbersCopy.Reverse();

            int[] rightSide = numbersCopy.Take(k).ToArray();

            int[] firstRow = leftSide.Concat(rightSide).ToArray();

            return firstRow;
        }
    }
}
