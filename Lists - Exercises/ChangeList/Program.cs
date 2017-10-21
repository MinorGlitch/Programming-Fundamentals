using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<string> command = Console.ReadLine().Split(' ').ToList();

            while (true)
            {
                switch (command[0])
                {
                    case "Delete":
                        {
                            int number = int.Parse(command[1]);

                            Delete(numbers, number);

                            break;
                        }
                    case "Insert":
                        {
                            int index = int.Parse(command[1]);

                            int numberToAdd = int.Parse(command[2]);

                            Insert(numbers, numberToAdd, index);

                            break;
                        }
                    case "Odd":
                        {
                            PrintOddNumbers(numbers);

                            return;
                        }
                    default:
                        {
                            PrintEvenNumbers(numbers);

                            return;
                        }
                }

                command = Console.ReadLine().Split(' ').ToList();
            }
        }

        private static void PrintEvenNumbers(List<int> allNumbers)
        {
            List<int> evenNumbers = new List<int>();

            for (int i = 0; i < allNumbers.Count; i++)
            {
                if (allNumbers[i] % 2 == 0)
                {
                    evenNumbers.Add(allNumbers[i]);
                }
            }

            Console.WriteLine(String.Join(" ", evenNumbers));
        }

        static void PrintOddNumbers(List<int> allNumbers)
        {
            List<int> oddNumbers = new List<int>();

            for (int i = 0; i < allNumbers.Count; i++)
            {
                if (allNumbers[i] % 2 != 0)
                {
                    oddNumbers.Add(allNumbers[i]);
                }
            }

            Console.WriteLine(String.Join(" ", oddNumbers));
        }

        private static void Insert(List<int> numbers, int numberToAdd, int index)
        {
            numbers.Insert(numberToAdd, index);
        }

        static void Delete(List<int> args, int number)
        {
            for (int i = 0; i < args.Count; i++)
            {
                args.Remove(number);
            }
        }
    }
}
