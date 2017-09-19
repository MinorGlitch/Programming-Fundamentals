using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilesToKilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            const double oneKilometer = 1.60934;

            double miles = double.Parse(Console.ReadLine());

            double kilometers = miles * oneKilometer;

            Console.WriteLine($"{kilometers:F2}");
        }
    }
}
