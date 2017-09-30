using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorVolumeOfPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = 0;
            double length = 0;
            double height = 0;

            double volume = 0;

            double pyramidBase = 0;

            Console.Write("Length: ");
            length = double.Parse(Console.ReadLine());

            Console.Write("Width: ");
            width = double.Parse(Console.ReadLine());

            Console.Write("Height: ");
            height = double.Parse(Console.ReadLine());

            pyramidBase = width * length;

            volume = (pyramidBase * height) / 3;

            Console.WriteLine($"Pyramid Volume: {volume:F2}");
        }
    }
}
