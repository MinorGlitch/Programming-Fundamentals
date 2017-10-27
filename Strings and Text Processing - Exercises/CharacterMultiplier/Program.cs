using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            char[] firstWord = input[0].ToCharArray();

            char[] secondWord = input[1].ToCharArray();

            int sum = 0;

            int shorterArr = Math.Min(firstWord.Length, secondWord.Length);

            for (int i = 0; i < shorterArr; i++)
            {
                sum += firstWord[i] * secondWord[i];
            }

            if (secondWord.Length - firstWord.Length > 0)
            {
                for (int i = firstWord.Length; i < secondWord.Length; i++)
                {
                    sum += secondWord[i];
                }
            }
            else
            {
                for (int i = secondWord.Length; i < firstWord.Length; i++)
                {
                    sum += firstWord[i];
                }
            }

            Console.WriteLine(sum);
        }
    }
}
