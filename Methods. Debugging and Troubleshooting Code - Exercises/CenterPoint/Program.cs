using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenterPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            string closestPair = PrintClosestPoint(x1, y1, x2, y2);

            Console.WriteLine(closestPair);
        }

        static string PrintClosestPoint(double x1, double y1, double x2, double y2)
        {
            string closestPair = null;

            if (Math.Pow(x1, 2) + Math.Pow(y1, 2) <= Math.Pow(x2, 2) + Math.Pow(y2, 2))
            {
                closestPair = $"({x1}, {y1})";
            }
            else
            {
                closestPair = $"({x2}, {y2})";
            }

            return closestPair;
        }
    }
}
