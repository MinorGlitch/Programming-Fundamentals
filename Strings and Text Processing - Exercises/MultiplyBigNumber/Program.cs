using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstNumber = Console.ReadLine().TrimStart('0');

            string multiplier = Console.ReadLine();

            if (firstNumber == "0" || multiplier == "0" || firstNumber == "")
            {
                Console.WriteLine(0);
                return;
            }

            StringBuilder sb = new StringBuilder();

            int mindNum = 0;

            for (int i = firstNumber.Length - 1; i >= 0; i--)
            {
                int sum = int.Parse(firstNumber[i].ToString()) * int.Parse(multiplier) + mindNum;

                int remainder = sum % 10;

                mindNum = sum / 10;

                sb.Append(remainder);

                if (i == 0 && mindNum > 0)
                {
                    sb.Append(mindNum);
                }
            }

            char[] output = ReverseString(sb);

            Console.WriteLine(output);
        }

        private static char[] ReverseString(StringBuilder sb)
        {
            return sb.ToString().ToCharArray().Reverse().ToArray();
        }
    }
}

