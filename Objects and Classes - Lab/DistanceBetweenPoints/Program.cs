using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceBetweenPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point();

            int[] p1Points = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            p1.X = p1Points[0];
            p1.Y = p1Points[1];

            Point p2 = new Point();

            int[] p2Points = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            p2.X = p2Points[0];
            p2.Y = p2Points[1];

            double distance = CalculateDistance(p1, p2);

            Console.WriteLine($"{distance:F3}");

        }

        private static double CalculateDistance(Point p1, Point p2)
        {
            int sideA = Math.Abs(p1.X - p2.X);
            int sideB = Math.Abs(p1.Y - p2.Y);

            double distance = Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2));

            return distance;
        }
    }

    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

}
