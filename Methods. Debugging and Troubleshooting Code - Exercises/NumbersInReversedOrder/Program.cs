using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersInReversedOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            string reversedNum = ReverseNumber(number);

            Console.WriteLine(reversedNum);
        }

        static string ReverseNumber(string number)
        {
            char[] reversedNumber = number.ToCharArray();

            Array.Reverse(reversedNumber);

            return new string(reversedNumber);
        }
    }
}
