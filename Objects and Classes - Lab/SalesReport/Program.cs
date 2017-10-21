using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesReport
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, double> salesByTown = new SortedDictionary<string, double>();

            int inputCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputCount; i++)
            {
                string[] input = Console.ReadLine().Split(' ');

                Sale currentSale = ReadSale(input);

                string currentCity = currentSale.Town;

                double currentProductPrice = currentSale.Price * currentSale.Quantity;

                if (!salesByTown.ContainsKey(currentSale.Town))
                {
                    salesByTown.Add(currentCity, currentProductPrice);
                }
                else
                {
                    salesByTown[currentCity] += currentProductPrice;
                }
            }

            foreach (KeyValuePair<string, double> town in salesByTown)
            {
                Console.WriteLine($"{town.Key} -> {town.Value:F2}");
            }
        }

        static Sale ReadSale(string[] inputArgs)
        {
            Sale newSale = new Sale();

            newSale.Town = inputArgs[0];

            newSale.Product = inputArgs[1];

            newSale.Price = double.Parse(inputArgs[2]);

            newSale.Quantity = double.Parse(inputArgs[3]);

            return newSale;
        }
    }

    class Sale
    {
        public string Town { get; set; }
        public string Product { get; set; }
        public double Price { get; set; }
        public double Quantity { get; set; }
    }
}
