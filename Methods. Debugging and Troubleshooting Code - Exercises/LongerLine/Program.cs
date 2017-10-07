using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongerLine
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            double firstLineLength = GetLineLength(x1, y1, x2, y2);
            double secondLineLength = GetLineLength(x3, y3, x4, y4);

            if (firstLineLength >= secondLineLength)
            {
                PrintResult(x1, y1, x2, y2);
            }
            else if (firstLineLength < secondLineLength)
            {
                PrintResult(x3, y3, x4, y4);
            }
        }

        static void PrintResult(double x1, double y1, double x2, double y2)
        {
            double distanceOne = Math.Sqrt(x1 * x1 + y1 * y1);
            double distanceTwo = Math.Sqrt(x2 * x2 + y2 * y2);

            if (distanceTwo >= distanceOne)
            {
                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
            }
        }

        private static double GetLineLength(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
        }
    }
}
