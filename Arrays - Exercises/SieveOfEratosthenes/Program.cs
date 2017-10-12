using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SieveOfEratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            bool[] boolArr = CreateBoolArray(n);

            GetPrimeValues(boolArr, n);
        }

        static bool[] CreateBoolArray(int n)
        {
            bool[] truePrimes = new bool[n + 1];

            for (int i = 0; i < truePrimes.Length; i++)
            {
                truePrimes[i] = true;
            }

            return truePrimes;
        }

        static void GetPrimeValues(bool[] boolArr, int n)
        {
            boolArr[0] = false;
            boolArr[1] = false;

            for (int i = 0; i < boolArr.Length; i++)
            {
                if (boolArr[i])
                {
                    Console.Write($"{i} ");

                    for (int j = 2; j * i <= n; j++)
                    {
                        boolArr[j * i] = false;
                    }
                }
            }
        }
    }
}
