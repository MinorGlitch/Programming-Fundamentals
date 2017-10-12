using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveNegativesAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<string> positiveReversedNumbers = RemoveNegativeNumbers(numbers);

            Console.WriteLine(String.Join(" ", positiveReversedNumbers));
        }

        static List<string> RemoveNegativeNumbers(List<int> numbers)
        {
            List<string> positiveNumbers = new List<string>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] >= 0)
                {
                    positiveNumbers.Add(numbers[i].ToString());
                }
            }

            if (positiveNumbers.Count == 0)
            {
                positiveNumbers.Add("empty");
            }

            positiveNumbers.Reverse();

            return positiveNumbers;
        }
    }
}
