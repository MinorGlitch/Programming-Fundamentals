using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            numbers.Sort();

            int position = 0;

            while (position < numbers.Count)
            {
                int number = numbers[position];

                int occurrenceCount = 1;

                while (position + occurrenceCount < numbers.Count && numbers[position + occurrenceCount] == number)
                {
                    occurrenceCount++;
                }

                position += occurrenceCount;

                Console.WriteLine($"{number} -> {occurrenceCount}");
            }
        }
    }
}
