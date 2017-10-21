using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClosestTwoPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Point> points = new List<Point>();

            int inputCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputCount; i++)
            {
                int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                Point p = new Point { X = numbers[0], Y = numbers[1] };

                points.Add(p);
            }

            Point[] clPoints = GetClosestPoints(points);

            double averageDistance = CalculateDistance(clPoints[0], clPoints[1]);

            Console.WriteLine($"{averageDistance:F3}");

            foreach (Point point in clPoints)
            {
                Console.WriteLine($"({point.X}, {point.Y})");
            }
        }

        static Point[] GetClosestPoints(List<Point> arr)
        {
            Point[] closestPoints = new Point[2];

            double minDistance = double.MaxValue;

            for (int i = 0; i < arr.Count; i++)
            {
                for (int j = i + 1; j < arr.Count; j++)
                {
                    if (CalculateDistance(arr[i], arr[j]) < minDistance)
                    {
                        minDistance = CalculateDistance(arr[i], arr[j]);

                        closestPoints[0] = arr[i];

                        closestPoints[1] = arr[j];
                    }
                }
            }

            return closestPoints;
        }

        static double CalculateDistance(Point x, Point x1)
        {
            double deltaX = x.X - x1.X;

            double deltaY = x.Y - x1.Y;

            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }
    }

    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}
