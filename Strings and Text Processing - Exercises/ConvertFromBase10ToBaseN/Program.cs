using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConvertFromBase10ToBaseN
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger[] inputArgs = Console.ReadLine().Split(' ').Select(BigInteger.Parse).ToArray();

            BigInteger numberBase = inputArgs[0];

            BigInteger decimalNumber = inputArgs[1];

            List<BigInteger> digits = new List<BigInteger>();

            while (decimalNumber != 0)
            {
                BigInteger bit = decimalNumber % numberBase;

                decimalNumber /= numberBase;

                digits.Add(bit);
            }

            digits.Reverse();

            Console.WriteLine(String.Join("", digits));
        }
    }
}
