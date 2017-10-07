using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimesInGivenRange
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            List<int> primeNumbers = CheckPrimesInRange(start, end);

            string result = string.Join(", ", primeNumbers);

            Console.WriteLine(result);
        }

        static List<int> CheckPrimesInRange(int start, int end)
        {
            List<int> primeNumbers = new List<int>();

            for (int i = start; i <= end; i++)
            {
                bool isPrime = true;

                if (i < 2)
                {
                    isPrime = false;
                }

                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    primeNumbers.Add(i);
                }
            }

            return primeNumbers;
        }
    }
}
