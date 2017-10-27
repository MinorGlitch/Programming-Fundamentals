using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicExchangeableWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ');

            string firstWord = words[0];

            string secondWord = words[1];

            char[] firstWordChars = firstWord.ToCharArray().Distinct().ToArray();
            char[] secondWordChars = secondWord.ToCharArray().Distinct().ToArray();

            if (firstWordChars.Length == secondWordChars.Length)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
