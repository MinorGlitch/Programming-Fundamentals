using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractMiddleElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] middleElements = GetMiddleElements(numbers);

            string output = $"{{{String.Join(", ", middleElements)}}}";

            Console.WriteLine(output);
        }

        static int[] GetMiddleElements(int[] array)
        {
            int[] middleElements = GetArrayType(array);

            if (middleElements.Length == 1)
            {
                middleElements[0] = array[0];
            }
            else if (middleElements.Length == 2)
            {
                middleElements[0] = array[array.Length / 2 - 1];
                middleElements[1] = array[array.Length / 2];
            }
            else if (middleElements.Length == 3)
            {
                middleElements[0] = array[array.Length / 2 - 1];
                middleElements[1] = array[array.Length / 2];
                middleElements[2] = array[array.Length / 2 + 1];
            }

            return middleElements;
        }

        static int[] GetArrayType(int[] array)
        {
            int arrLength = 0;

            if (array.Length % 2 == 0)
            {
                arrLength = 2;
            }
            else if (array.Length % 2 != 0 && array.Length > 1)
            {
                arrLength = 3;
            }
            else if (array.Length == 1)
            {
                arrLength = 1;
            }

            int[] middleElements = new int[arrLength];

            return middleElements;
        }
    }
}
