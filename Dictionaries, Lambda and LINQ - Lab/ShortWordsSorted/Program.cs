using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortWordsSorted
{
    class Program
    {
        private static char[] delimiter = { '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ' };

        static void Main(string[] args)
        {
            string words = Console.ReadLine().ToLower();

            string[] sentence = words.Split(delimiter);

            var shortWords = sentence.Where(x => x != "" && x.Length < 5).Distinct().OrderBy(x => x);

            Console.WriteLine(String.Join(", ", shortWords));
        }
    }
}
