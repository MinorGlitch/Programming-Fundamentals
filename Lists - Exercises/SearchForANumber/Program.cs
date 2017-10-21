using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchForANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int[] arguments = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            string output = ManipulateNumbers(numbers, arguments);

            Console.WriteLine(output);
        }

        private static string ManipulateNumbers(List<int> numbers, int[] arguments)
        {
            List<int> numbersTaken = new List<int>();

            for (int i = 0; i < arguments[0]; i++)
            {
                numbersTaken.Add(numbers[i]);
            }

            numbersTaken.RemoveRange(0, arguments[1]);

            if (numbersTaken.Contains(arguments[2]))
            {
                return "YES!";
            }

            return "NO!";
        }
    }
}
