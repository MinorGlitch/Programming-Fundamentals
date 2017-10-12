using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            char[] characters = word.ToCharArray();

            char[] alphabet = CreateAlphabet();

            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (characters[i] == alphabet[j])
                    {
                        Console.WriteLine($"{word[i]} -> {j}");
                    }
                }
            }
        }

        static char[] CreateAlphabet()
        {
            char[] array = new char[29];

            int arrIndex = 0;

            for (int i = 97; i <= 122; i++)
            {
                array[arrIndex] = (char)i;
                arrIndex++;
            }

            return array;
        }
    }
}
