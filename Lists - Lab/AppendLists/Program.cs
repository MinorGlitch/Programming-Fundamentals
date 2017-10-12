using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppendLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> tokens = Console.ReadLine().Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            List<string> numbers = GetNumbers(tokens);

            Console.WriteLine(String.Join(" ", numbers));
        }

        static List<string> GetNumbers(List<string> tokens)
        {
            List<string> numbers = new List<string>();

            for (int i = tokens.Count - 1; i >= 0; i--)
            {
                string[] elements = tokens[i].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                numbers.AddRange(elements);
            }

            return numbers;
        }
    }
}
