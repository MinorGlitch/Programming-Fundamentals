using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastKNumbersSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            long[] elements = GenerateElements(n);

            elements[0] = 1;

            sumLastElements(elements, k);

            Console.WriteLine(String.Join(" ", elements));
        }

        static long[] GenerateElements(long n)
        {
            return new long[n];
        }

        static void sumLastElements(long[] elements, int sumCount)
        {
            for (int i = 1; i < elements.Length; i++)
            {
                long sum = 0;

                for (int j = i - sumCount; j <= i - 1; j++)
                {
                    if (j >= 0)
                    {
                        sum += elements[j];
                    }

                    elements[i] = sum;
                }
            }
        }
    }
}
