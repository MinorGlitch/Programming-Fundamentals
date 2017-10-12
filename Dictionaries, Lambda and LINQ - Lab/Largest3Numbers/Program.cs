using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            List<double> largestNumbers = numbers.OrderByDescending(x => x).Take(3).ToList();

            Console.WriteLine(String.Join(" ", largestNumbers));
        }
    }
}
