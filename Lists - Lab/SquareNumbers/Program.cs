using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<int> squareNumbers = GetSquareNumbers(numbers);

            Console.WriteLine(String.Join(" ", squareNumbers));
        }

        static List<int> GetSquareNumbers(List<int> numbers)
        {
            List<int> squareNumbers = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (Math.Sqrt(numbers[i]) == (int)Math.Sqrt(numbers[i]))
                {
                    squareNumbers.Add(numbers[i]);
                }
            }

            squareNumbers.Sort((a, b) => b.CompareTo(a));

            return squareNumbers;
        }
    }
}
