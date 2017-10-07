using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double area = 0;

            string figure = Console.ReadLine();

            switch (figure)
            {
                case "triangle":
                    double side = double.Parse(Console.ReadLine());
                    double height = double.Parse(Console.ReadLine());

                    area = CalculateTriangleArea(side, height);

                    break;
                case "square":
                    side = double.Parse(Console.ReadLine());

                    area = CalculateSquareArea(side);

                    break;
                case "rectangle":
                    var width = double.Parse(Console.ReadLine());
                    height = double.Parse(Console.ReadLine());

                    area = CalculateRectangleArea(width, height);

                    break;
                case "circle":
                    var radius = double.Parse(Console.ReadLine());

                    area = CalculateCircleArea(radius);

                    break;
            }

            Console.WriteLine($"{area:F2}");
        }

        static double CalculateTriangleArea(double side, double height)
        {
            return (side * height) / 2;
        }

        static double CalculateSquareArea(double side)
        {
            return side * side;
        }

        static double CalculateRectangleArea(double width, double height)
        {
            return width * height;
        }

        static double CalculateCircleArea(double radius)
        {
            return Math.PI * radius * radius;
        }
    }
}
