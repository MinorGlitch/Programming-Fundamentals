using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            string[] commandArguments = Console.ReadLine().Split(' ');

            int index = 0;

            while (commandArguments[0] != "print")
            {
                switch (commandArguments[0])
                {
                    case "add":
                        {
                            index = int.Parse(commandArguments[1]);

                            int number = int.Parse(commandArguments[2]);

                            Add(numbers, index, number);

                            break;
                        }
                    case "addMany":
                        {
                            index = int.Parse(commandArguments[1]);

                            List<int> numbersToAdd = new List<int>();

                            for (int i = 2; i < commandArguments.Length; i++)
                            {
                                numbersToAdd.Add(int.Parse(commandArguments[i]));
                            }

                            AddMany(numbers, numbersToAdd, index);

                            break;
                        }
                    case "contains":
                        {
                            int number = int.Parse(commandArguments[1]);

                            Contains(numbers, number);

                            break;
                        }
                    case "remove":
                        {
                            index = int.Parse(commandArguments[1]);

                            Remove(numbers, index);

                            break;
                        }
                    case "shift":
                        {
                            int positions = int.Parse(commandArguments[1]);

                            ShiftLeft(numbers, positions);

                            break;
                        }
                    case "sumPairs":
                        {
                            SumPairs(numbers);

                            break;
                        }
                }

                commandArguments = Console.ReadLine().Split(' ');
            }

            string output = $"[{String.Join(", ", numbers)}]";

            Console.WriteLine(output);
        }

        static void Add(List<int> numbers, int index, int element)
        {
            numbers.Insert(index, element);
        }

        static void AddMany(List<int> numbers, List<int> numbersToAdd, int index)
        {
            numbers.InsertRange(index, numbersToAdd);
        }

        static void Contains(List<int> numbers, int number)
        {
            if (numbers.Contains(number))
            {
                Console.WriteLine(numbers.IndexOf(number));
            }
            else
            {
                Console.WriteLine(-1);
            }
        }

        static void Remove(List<int> numbers, int index)
        {
            numbers.RemoveAt(index);
        }

        static void ShiftLeft(List<int> numbers, int shiftCount)
        {

            for (int i = 0; i < shiftCount; i++)
            {
                int firstElement = numbers[0];

                for (int j = 0; j < numbers.Count - 1; j++)
                {
                    numbers[j] = numbers[j + 1];
                }

                numbers[numbers.Count - 1] = firstElement;
            }
        }

        static void SumPairs(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                int sum = numbers[i] + numbers[i + 1];
                numbers[i] = sum;
                numbers.RemoveAt(i + 1);
            }
        }
    }
}
