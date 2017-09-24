using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantDiscount
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());

            string packageType = Console.ReadLine();

            string hallSize = null;

            int hallPrice = 0;

            int discountOnPurchase = 0;

            int packagePrice = 0;

            double totalPrice = 0;

            double totalPriceDiscount = 0;

            double pricePerPerson = 0;

            bool smallHall = groupSize > 0 && groupSize <= 50;

            bool terrace = groupSize > 50 && groupSize <= 100;

            bool greatHall = groupSize > 100 && groupSize <= 120;

            if (smallHall)
            {
                hallSize = "Small Hall";
                hallPrice = 2500;
            }
            else if (terrace)
            {
                hallSize = "Terrace";
                hallPrice = 5000;
            }
            else if (greatHall)
            {
                hallSize = "Great Hall";
                hallPrice = 7500;
            }
            else
            {
                hallSize = "We do not have an appropriate hall.";
            }

            switch (packageType)
            {
                case "Gold":
                    discountOnPurchase = 10;
                    packagePrice = 750;
                    break;
                case "Normal":
                    discountOnPurchase = 5;
                    packagePrice = 500;
                    break;
                case "Platinum":
                    discountOnPurchase = 15;
                    packagePrice = 1000;
                    break;
            }

            totalPriceDiscount = (hallPrice + packagePrice) * discountOnPurchase / 100;

            totalPrice = (hallPrice + packagePrice) - totalPriceDiscount;

            pricePerPerson = totalPrice / groupSize;

            if (!(hallSize == "We do not have an appropriate hall."))
            {
                Console.WriteLine($"We can offer you the {hallSize}");
                Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
            }
            else
            {
                Console.WriteLine(hallSize);
            }
        }
    }
}
