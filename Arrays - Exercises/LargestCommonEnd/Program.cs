using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestCommonEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArr = Console.ReadLine().Split(' ');
            string[] secondArr = Console.ReadLine().Split(' ');

            int leftSideCount = GetCommonItems(firstArr, secondArr);

            Array.Reverse(firstArr);
            Array.Reverse(secondArr);

            int rightSideCount = GetCommonItems(firstArr, secondArr);

            int largerSide = Math.Max(leftSideCount, rightSideCount);

            Console.WriteLine(largerSide);
        }

        static int GetCommonItems(string[] firstArr, string[] secondArr)
        {
            int shorterArray = Math.Min(firstArr.Length, secondArr.Length);

            int count = 0;

            for (int i = 0; i < shorterArray; i++)
            {
                if (firstArr[i] == secondArr[i])
                {
                    count++;
                }
            }

            return count;
        }
    }
}
