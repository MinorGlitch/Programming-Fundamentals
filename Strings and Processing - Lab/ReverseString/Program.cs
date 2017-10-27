using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string reverseStr = ReverseString(Console.ReadLine());

            Console.WriteLine(reverseStr);
        }

        private static string ReverseString(string str)
        {
            string reversed = null;

            for (int i = str.Length - 1; i >= 0; i--)
            {
                reversed += str[i];
            }

            return reversed;
        }
    }
}
