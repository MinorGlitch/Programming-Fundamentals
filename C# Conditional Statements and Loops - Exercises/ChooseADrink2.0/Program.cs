using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChooseADrink2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();

            int quantity = int.Parse(Console.ReadLine());

            string drink = null;

            double coffeePrice = 1.0;
            double waterPrice = 0.7;
            double beerPrice = 1.7;
            double teaPrice = 1.2;

            double bill = 0d;

            switch (profession)
            {
                case "Athlete":
                    drink = "Water";
                    bill = waterPrice * quantity;
                    break;
                case "Businessman":
                case "Businesswoman":
                    drink = "Coffee";
                    bill = coffeePrice * quantity;
                    break;
                case "SoftUni Student":
                    drink = "Beer";
                    bill = beerPrice * quantity;
                    break;
                default:
                    drink = "Tea";
                    bill = teaPrice * quantity;
                    break;
            }

            Console.WriteLine($"The {profession} has to pay {bill:F2}.");
        }
    }
}
