using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparingFloats
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            double precision = 0.000001;

            bool areEqual = false;

            if (Math.Abs(a - b) <= precision)
            {
                areEqual = true;
            }
            else
            {
                areEqual = false;
            }

            Console.WriteLine(areEqual);
        }
    }
}
