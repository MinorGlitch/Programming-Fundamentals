using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountSubstringOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();

            string pattern = Console.ReadLine().ToLower();

            int occurrencesOfPattern = CountOccurrences(text, pattern);

            Console.WriteLine(occurrencesOfPattern);
        }

        private static int CountOccurrences(string text, string pattern)
        {
            int count = 0;

            int index = text.IndexOf(pattern);

            while (index != -1)
            {
                count++;

                index = text.IndexOf(pattern, index + 1);
            }

            return count;
        }
    }
}
