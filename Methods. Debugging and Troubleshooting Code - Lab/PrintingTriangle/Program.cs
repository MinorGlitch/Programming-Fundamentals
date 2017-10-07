using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintingTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            PrintUpperHalf(n);
            PrintLowerHalf(n);
        }

        static void PrintLine(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }

        static void PrintUpperHalf(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                PrintLine(i);
            }
        }

        static void PrintLowerHalf(int n)
        {
            for (int i = n - 1; i > 0; i--)
            {
                PrintLine(i);
            }
        }
    }
}