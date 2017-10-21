using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = File.ReadAllText("text.txt").ToLower().Split(new[] { '.', '!', '?', '\r', '\n', ' ', ',', '-' }, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> matchedWords = new Dictionary<string, int>();

            string[] wordsToCompare = File.ReadAllText("words.txt").Split(' ');

            foreach (string line in text)
            {
                string[] lineWords = line.Split(' ');

                foreach (string lineWord in lineWords)
                {
                    if (wordsToCompare.Contains(lineWord))
                    {
                        if (!matchedWords.ContainsKey(lineWord))
                        {
                            matchedWords[lineWord] = 1;
                        }
                        else
                        {
                            matchedWords[lineWord] += 1;
                        }
                    }
                }
            }

            foreach (KeyValuePair<string, int> wordCount in matchedWords.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{wordCount.Key} -> {wordCount.Value}");
            }
        }
    }
}
