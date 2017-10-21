using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopulationCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('|');

            Dictionary<string, Dictionary<string, long>> countries = new Dictionary<string, Dictionary<string, long>>();

            while (input[0] != "report")
            {
                string city = input[0];

                string country = input[1];

                long currentPopulation = long.Parse(input[2]);

                if (!countries.ContainsKey(country))
                {
                    countries.Add(country, new Dictionary<string, long>());
                }

                CalculatePopulation(countries[country], city, currentPopulation);

                input = Console.ReadLine().Split('|');
            }

            countries = countries.OrderByDescending(x => x.Value.Values.Sum()).ToDictionary(x => x.Key, x => x.Value);

            PrintPopulation(countries);
        }

        static void PrintPopulation(Dictionary<string, Dictionary<string, long>> countries)
        {
            foreach (KeyValuePair<string, Dictionary<string, long>> country in countries)
            {
                Console.WriteLine($"{country.Key} (total population: {country.Value.Values.Sum()})");

                foreach (KeyValuePair<string, long> city in country.Value.OrderByDescending(c => c.Value))
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }
            }
        }

        private static void CalculatePopulation(Dictionary<string, long> population, string city, long currentPopulation)
        {
            if (!population.ContainsKey(city))
            {
                population[city] = currentPopulation;
            }
            else
            {
                population[city] += currentPopulation;
            }
        }
    }
}
