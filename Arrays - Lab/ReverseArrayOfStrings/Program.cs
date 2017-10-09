using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrayOfStrings = Console.ReadLine().Split(' ');

            arrayOfStrings = ReverseArray(arrayOfStrings);

            Console.WriteLine(String.Join(" ", arrayOfStrings));
        }

        static string[] ReverseArray(string[] array)
        {
            return array.Reverse().ToArray();
        }
    }
}
