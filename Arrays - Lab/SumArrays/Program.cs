using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] secondArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] largerArray = GetBiggerArray(firstArray, secondArray);

            int[] summedArray = new int[largerArray.Length];

            for (int i = 0; i < largerArray.Length; i++)
            {
                summedArray[i] = firstArray[i % firstArray.Length] + secondArray[i % secondArray.Length];
            }

            Console.WriteLine(String.Join(" ", summedArray));
        }

        static int[] GetBiggerArray(int[] arrOne, int[] arrTwo)
        {
            if (arrOne.Length > arrTwo.Length)
            {
                return arrOne;
            }
            return arrTwo;
        }
    }
}
