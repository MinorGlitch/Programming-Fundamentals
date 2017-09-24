using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeIngredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string ingredient = Console.ReadLine();

            int productsCount = 0;

            while (ingredient != "Bake!")
            {
                Console.WriteLine($"Adding ingredient {ingredient}.");
                productsCount++;
                ingredient = Console.ReadLine();
            }

            Console.WriteLine($"Preparing cake with {productsCount} ingredients.");
        }
    }
}
