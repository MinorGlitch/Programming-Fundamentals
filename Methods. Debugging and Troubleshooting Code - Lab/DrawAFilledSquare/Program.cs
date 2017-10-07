using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawAFilledSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            int squareSize = int.Parse(Console.ReadLine());

            HeaderAndFooter(squareSize);
            PrintMiddlePart(squareSize);
            HeaderAndFooter(squareSize);
        }

        static void HeaderAndFooter(int size)
        {
            Console.WriteLine(new string('-', size * 2));
        }

        static void PrintMiddlePart(int size)
        {
            for (int i = 0; i < size - 2; i++)
            {
                Console.Write('-');
                for (int j = 0; j < size - 1; j++)
                {
                    Console.Write(@"\/");
                }
                Console.WriteLine('-');
            }
        }
    }
}
