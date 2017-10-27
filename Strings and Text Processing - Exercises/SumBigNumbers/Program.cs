using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumBigNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstNumber = Console.ReadLine();

            string secondNumber = Console.ReadLine();

            if (firstNumber.Length > secondNumber.Length)
            {
                secondNumber = secondNumber.PadLeft(firstNumber.Length, '0');
            }
            else
            {
                firstNumber = firstNumber.PadLeft(secondNumber.Length, '0');
            }

            StringBuilder sb = new StringBuilder();

            int remainder = 0;

            for (int i = firstNumber.Length - 1; i >= 0; i--)
            {
                int sum = firstNumber[i] - 48 + secondNumber[i] - 48 + remainder;

                int number = sum % 10;

                remainder = sum / 10;

                sb.Append(number);

                if (i == 0 && remainder > 0)
                {
                    sb.Append(remainder);
                }
            }

            char[] output = ReverseString(sb);

            Console.WriteLine(output);
        }

        private static char[] ReverseString(StringBuilder sb)
        {
            return sb.ToString().TrimEnd('0').ToCharArray().Reverse().ToArray();
        }
    }
}
