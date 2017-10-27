using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
            string textWords = Console.ReadLine();

            foreach (string bannedWord in bannedWords)
            {
                if (textWords.Contains(bannedWord))
                {
                    textWords = textWords.Replace(bannedWord, new string('*', bannedWord.Length));
                }
            }

            Console.WriteLine(textWords);
        }
    }
}
