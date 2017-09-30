using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelOrDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            char input = char.Parse(Console.ReadLine());

            char[] vowels = new char[5] { 'a', 'e', 'o', 'u', 'i' };

            if (vowels.Contains(input))
            {
                Console.WriteLine("vowel");
            }
            else if (Char.IsDigit(input))
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
