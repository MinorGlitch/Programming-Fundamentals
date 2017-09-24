using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5DifferentNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            if (Math.Abs(start - end) < 5)
            {
                Console.WriteLine("No");
            }

            for (int a = start; a <= end; a++)
            {
                for (int b = start; b <= end; b++)
                {
                    for (int c = start; c <= end; c++)
                    {
                        for (int d = start; d <= end; d++)
                        {
                            for (int e = start; e <= end; e++)
                            {
                                if (start <= a && a < b && b < c && c < d && d < e && e <= end)
                                {
                                    Console.WriteLine($"{a} {b} {c} {d} {e}");

                                }

                            }
                        }
                    }
                }
            }


        }
    }
}
