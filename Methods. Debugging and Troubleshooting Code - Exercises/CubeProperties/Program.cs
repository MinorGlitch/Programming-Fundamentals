using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            double cubeSide = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();

            double result = CalculateParameters(parameter, cubeSide);

            Console.WriteLine($"{result:F2}");
        }

        static double CalculateParameters(string parameter, double side)
        {
            switch (parameter)
            {
                case "face":
                    return Math.Sqrt(2 * Math.Pow(side, 2));
                case "space":
                    return Math.Sqrt(3 * Math.Pow(side, 2));
                case "volume":
                    return Math.Pow(side, 3);
                case "area":
                    return 6 * Math.Pow(side, 2);
            }

            return 0;
        }
    }
}
