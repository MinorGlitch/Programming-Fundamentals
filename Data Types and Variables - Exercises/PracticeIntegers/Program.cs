using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] numbers = new long[7] { -100, 128, -3540, 64876, 2147483648, -1141583228, -1223372036854775808 };

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
