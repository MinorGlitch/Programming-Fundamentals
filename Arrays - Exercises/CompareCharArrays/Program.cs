using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareCharArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] firstArr = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] secondArr = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

            if (firstArr.Length > secondArr.Length)
            {
                Console.WriteLine(String.Join("", secondArr));
                Console.WriteLine(String.Join("", firstArr));
            }
            else if (firstArr.Length < secondArr.Length)
            {
                Console.WriteLine(String.Join("", firstArr));
                Console.WriteLine(String.Join("", secondArr));
            }
            else
            {
                for (int i = 0; i < firstArr.Length; i++)
                {
                    if (firstArr[i] > secondArr[i])
                    {
                        Console.WriteLine(String.Join("", secondArr));
                        Console.WriteLine(String.Join("", firstArr));

                        break;
                    }

                    Console.WriteLine(String.Join("", firstArr));
                    Console.WriteLine(String.Join("", secondArr));

                    break;
                }
            }
        }
    }
}
