using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirclesIntersection
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArgs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Circle firstCircle = new Circle(inputArgs[0], inputArgs[1], inputArgs[2]);

            inputArgs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Circle secondCircle = new Circle(inputArgs[0], inputArgs[1], inputArgs[2]);

            string isIntersect = Intersect(firstCircle, secondCircle);

            Console.WriteLine(isIntersect);
        }

        private static string Intersect(Circle firstCircle, Circle secondCircle)
        {
            int sumOfRadiuses = firstCircle.Radius + secondCircle.Radius;

            double distance =
                Math.Sqrt(Math.Pow(firstCircle.Center.X - secondCircle.Center.X, 2) +
                Math.Pow(firstCircle.Center.Y - secondCircle.Center.Y, 2));

            if (sumOfRadiuses >= distance)
            {
                return "Yes";
            }

            return "No";
        }
    }

    class Circle
    {
        public Point Center { get; set; }
        public int Radius { get; set; }

        public Circle(int x, int y, int radius)
        {
            Center = new Point(x, y);
            Radius = radius;
        }

    }

    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
