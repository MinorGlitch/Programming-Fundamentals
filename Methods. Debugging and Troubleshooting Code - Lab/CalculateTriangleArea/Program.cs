using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateTriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double area = CalculateTriangeArea(width, height);

            Console.WriteLine(area);
        }

        static double CalculateTriangeArea(double width, double height)
        {
            return width * height / 2;
        }
    }
}
