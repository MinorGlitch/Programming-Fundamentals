using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            List<double> numbers = new List<double>();

            foreach (string wordCombo in input)
            {
                string currentWord = wordCombo;

                int charPosition = 0;

                char leftLetter = currentWord[0];
                char rightLetter = currentWord[currentWord.Length - 1];

                currentWord = currentWord.Remove(0, 1);
                currentWord = currentWord.Remove(currentWord.Length - 1, 1);

                double result = double.Parse(currentWord);

                charPosition = leftLetter % 32;

                if (Char.IsUpper(leftLetter))
                {
                    result /= charPosition;
                }
                else
                {
                    result *= charPosition;
                }

                charPosition = rightLetter % 32;

                if (Char.IsUpper(rightLetter))
                {
                    result -= charPosition;
                }
                else
                {
                    result += charPosition;
                }

                numbers.Add(result);
            }

            double finalSum = 0.0d;

            numbers.ForEach(delegate (Double num)
            {
                finalSum += num;
            });

            Console.WriteLine($"{finalSum:F2}");
        }
    }
}
