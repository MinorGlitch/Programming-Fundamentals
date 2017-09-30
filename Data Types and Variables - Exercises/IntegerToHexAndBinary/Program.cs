using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerToHexAndBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            string hexadecimalNumber = Convert.ToString(number, 16).ToUpper();

            string binaryNumber = Convert.ToString(number, 2);

            Console.WriteLine(hexadecimalNumber);
            Console.WriteLine(binaryNumber);
        }
    }
}
