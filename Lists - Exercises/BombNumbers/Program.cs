using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<int> bombNumberAndPower = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int sum = RemoveBombNumbers(numbers, bombNumberAndPower);

            Console.WriteLine(sum);
        }

        static int RemoveBombNumbers(List<int> numbers, List<int> specialNumbers)
        {
            int bombNumber = specialNumbers[0];

            int power = specialNumbers[1];

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == bombNumber)
                {
                    int leftSide = Math.Max(i - power, 0);

                    int rightSide = Math.Min(i + power, numbers.Count - 1);

                    int bombLength = Math.Abs(leftSide - rightSide) + 1;

                    numbers.RemoveRange(leftSide, bombLength);

                    i = 0;
                }
            }

            return numbers.Sum();
        }
    }
}
