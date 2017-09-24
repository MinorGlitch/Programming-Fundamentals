using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriesCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            int ingredients = int.Parse(Console.ReadLine());

            int calories = 0;

            for (int i = 1; i <= ingredients; i++)
            {
                string product = Console.ReadLine();

                if (product.Equals("Cheese", StringComparison.OrdinalIgnoreCase))
                {
                    calories += 500;
                }
                else if (product.Equals("Tomato sauce", StringComparison.OrdinalIgnoreCase))
                {
                    calories += 150;
                }
                else if (product.Equals("Salami", StringComparison.OrdinalIgnoreCase))
                {
                    calories += 600;
                }
                else if (product.Equals("Pepper", StringComparison.OrdinalIgnoreCase))
                {
                    calories += 50;
                }
            }

            Console.WriteLine($"Total calories: {calories}");
        }
    }
}
