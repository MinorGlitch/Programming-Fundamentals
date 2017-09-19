using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebitCardNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int sectionOne = int.Parse(Console.ReadLine());
            int sectionTwo = int.Parse(Console.ReadLine());
            int sectionThree = int.Parse(Console.ReadLine());
            int sectionFour = int.Parse(Console.ReadLine());

            Console.WriteLine($"{sectionOne:D4} {sectionTwo:D4} {sectionThree:D4} {sectionFour:D4}");
        }
    }
}
