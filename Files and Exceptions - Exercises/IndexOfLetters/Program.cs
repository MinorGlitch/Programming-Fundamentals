using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            File.WriteAllText("input.txt", String.Empty);

            //Replace String.Empty with your input arguments.

            string word = File.ReadAllText("input.txt");

            char[] characters = word.ToCharArray();

            char[] alphabet = CreateAlphabet();

            File.WriteAllText("output.txt", String.Empty);

            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (characters[i] == alphabet[j])
                    {
                        string currentOutput = $"{word[i]} -> {j}" + Environment.NewLine;

                        File.AppendAllText("output.txt", currentOutput);
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
