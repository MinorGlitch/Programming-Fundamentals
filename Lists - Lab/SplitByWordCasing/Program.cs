using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitByWordCasing
{
    class Program
    {
        static char[] delimiters = { ',', '.', ';', ':', '(', ')', '"', '\'', '\\', '/', '[', ']', ' ', '!' };

        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split(delimiters, StringSplitOptions.RemoveEmptyEntries).ToList();

            GroupWords(words);
        }

        static void GroupWords(List<string> words)
        {
            List<string> lowercaseWords = new List<string>();
            List<string> mixedcaseWords = new List<string>();
            List<string> uppercaseWords = new List<string>();

            for (int i = 0; i < words.Count; i++)
            {
                string currentWord = words[i];

                if (currentWord.All(char.IsUpper))
                {
                    uppercaseWords.Add(currentWord);
                }
                else if (currentWord.All(char.IsLower))
                {
                    lowercaseWords.Add(currentWord);
                }
                else
                {
                    mixedcaseWords.Add(currentWord);
                }
            }

            PrintResult(uppercaseWords, lowercaseWords, mixedcaseWords);
        }

        private static void PrintResult(List<string> uppercaseWords, List<string> lowercaseWords, List<string> mixedcaseWords)
        {
            Console.WriteLine($"Lower-case: {String.Join(", ", lowercaseWords)}");
            Console.WriteLine($"Mixed-case: {String.Join(", ", mixedcaseWords)}");
            Console.WriteLine($"Upper-case: {String.Join(", ", uppercaseWords)}");
        }
    }
}
