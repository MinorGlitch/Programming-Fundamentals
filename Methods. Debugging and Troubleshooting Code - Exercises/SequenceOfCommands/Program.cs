using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SequenceOfCommands
{
    class Program
    {
        private const char ArgumentsDelimiter = ' ';

        public static void Main()
        {
            int sizeOfArray = int.Parse(Console.ReadLine());

            long[] array = Console.ReadLine()
                .Split(ArgumentsDelimiter)
                .Select(long.Parse)
                .ToArray();

            string command = Console.ReadLine();

            while (!command.Equals("stop"))
            {
                string[] line = command.Split(ArgumentsDelimiter);

                int[] stringParams = new int[2];

                string parameter = line[0];

                if (parameter.Equals("add") ||
                    parameter.Equals("subtract") ||
                    parameter.Equals("multiply"))
                {
                    stringParams[0] = int.Parse(line[1]);
                    stringParams[1] = int.Parse(line[2]);
                }

                PerformAction(array, parameter, stringParams);

                Console.WriteLine(PrintArray(array));

                command = Console.ReadLine();
            }
        }

        static void PerformAction(long[] arr, string action, int[] args)
        {
            int position = args[0];
            int value = args[1];

            switch (action)
            {
                case "multiply":
                    arr[position - 1] *= value;
                    break;
                case "add":
                    arr[position - 1] += value;
                    break;
                case "subtract":
                    arr[position - 1] -= value;
                    break;
                case "lshift":
                    ArrayShiftLeft(arr);
                    break;
                case "rshift":
                    ArrayShiftRight(arr);
                    break;
            }
        }

        private static void ArrayShiftRight(long[] array)
        {
            long lastElement = array[array.Length - 1];

            for (int i = array.Length - 1; i >= 1; i--)
            {
                array[i] = array[i - 1];
            }

            array[0] = lastElement;
        }

        private static void ArrayShiftLeft(long[] array)
        {
            long firstElement = array[0];

            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }

            array[array.Length - 1] = firstElement;
        }

        private static string PrintArray(long[] array)
        {
            string output = String.Join(" ", array);

            return output;
        }
    }
}
