using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ');

            Random rnd = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                int firstWordIndex = rnd.Next(0, words.Length);

                int secondWordIndex = rnd.Next(0, words.Length);

                string tempWord = words[firstWordIndex];

                words[firstWordIndex] = words[secondWordIndex];

                words[secondWordIndex] = tempWord;
            }

            Console.WriteLine(String.Join("\n", words));
        }
    }
}
