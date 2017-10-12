using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {

            string wordSequence = Console.ReadLine().ToLower();
            string[] words = wordSequence.Split(' ').ToArray();

            Dictionary<string, int> oddWords = new Dictionary<string, int>();

            foreach (string word in words)
            {
                if (oddWords.ContainsKey(word))
                {
                    oddWords[word]++;
                }
                else
                {
                    oddWords[word] = 1;
                }
            }

            List<string> finalWords = new List<string>();

            foreach (KeyValuePair<string, int> oddWord in oddWords)
            {
                if (oddWord.Value % 2 != 0)
                {
                    finalWords.Add(oddWord.Key);
                }
            }

            Console.WriteLine(String.Join(", ", finalWords));
        }
    }
}
