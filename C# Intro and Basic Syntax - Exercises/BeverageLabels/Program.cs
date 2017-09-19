using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeverageLabels
{
    class Program
    {
        static void Main(string[] args)
        {
            string beverageName = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            int energyContent = int.Parse(Console.ReadLine());
            int sugarContent = int.Parse(Console.ReadLine());

            double calories = (volume * energyContent) / 100.0;
            double sugars = (volume * sugarContent) / 100.0;

            Console.WriteLine($"{volume}ml {beverageName}:");
            Console.WriteLine($"{calories}kcal, {sugars}g sugars");
        }
    }
}
