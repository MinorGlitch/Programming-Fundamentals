using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceChangeAlert
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPrices = int.Parse(Console.ReadLine());

            double significanceThreshold = double.Parse(Console.ReadLine());

            double lastPrice = double.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfPrices - 1; i++)
            {
                double currentPrice = double.Parse(Console.ReadLine());

                double difference = CalculateDifference(lastPrice, currentPrice);

                bool isDifferent = CheckForDifference(difference, significanceThreshold);

                string output = PrintDifference(currentPrice, lastPrice, difference, isDifferent);

                Console.WriteLine(output);

                lastPrice = currentPrice;
            }
        }

        static string PrintDifference(double currentPrice, double lastPrice, double difference, bool trueOrFalse)
        {
            string output = null;

            difference *= 100;

            if (difference == 0)
            {
                output = $"NO CHANGE: {currentPrice}";
            }
            else if (!trueOrFalse)
            {
                output = $"MINOR CHANGE: {lastPrice} to {currentPrice} ({difference:F2}%)";
            }
            else if (trueOrFalse && difference > 0)
            {
                output = $"PRICE UP: {lastPrice} to {currentPrice} ({difference:F2}%)";
            }
            else if (trueOrFalse && difference < 0)
            {
                output = $"PRICE DOWN: {lastPrice} to {currentPrice} ({difference:F2}%)";
            }

            return output;
        }

        static bool CheckForDifference(double border, double isDiff)
        {
            return Math.Abs(border) >= isDiff;
        }

        static double CalculateDifference(double lastPrice, double currentPrice)
        {
            return (currentPrice - lastPrice) / lastPrice;
        }
    }
}

