using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine()
                .Split(new[] { ',', '.', ' ', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            SortedSet<string> palindromes = new SortedSet<string>();

            foreach (string word in text)
            {
                if (IsPalindrome(word))
                {
                    palindromes.Add(word);
                }
            }

            Console.WriteLine(String.Join(", ", palindromes));
        }

        private static bool IsPalindrome(string word)
        {
            char[] reversedWordChars = word.ToCharArray().Reverse().ToArray();

            string reversedWord = new string(reversedWordChars);

            if (reversedWord == word)
            {
                return true;
            }

            return false;
        }
    }
}
