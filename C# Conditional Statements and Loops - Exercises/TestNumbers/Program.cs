using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int sumBoundary = int.Parse(Console.ReadLine());

            int currentSum = 0;
            int count = 0;

            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= m; j++)
                {
                    currentSum += (i * j) * 3;
                    count++;

                    if (currentSum >= sumBoundary)
                    {
                        Console.WriteLine($"{count} combinations");
                        Console.WriteLine($"Sum: {currentSum} >= {sumBoundary}");
                        return;
                    }
                }
            }

            if (currentSum < sumBoundary)
            {
                Console.WriteLine($"{count} combinations");
                Console.WriteLine($"Sum: {currentSum}");
            }
        }
    }
}
