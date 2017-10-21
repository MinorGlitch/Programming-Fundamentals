using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvertisementMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] events =
            {
                "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!"
            };

            string[] phrases =
            {
                "Excellent product.", "Such a great product.", "I always use that product.",
                "Best product of its category.", "Exceptional product.", "I can’t live without this product."
            };

            string[] authors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };

            string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            File.WriteAllText("input.txt", String.Empty);

            //Replace String.Empty with your input arguments.

            int phrasesCount = int.Parse(File.ReadAllText("input.txt"));

            Random rnd = new Random();

            File.WriteAllText("output.txt", String.Empty);

            for (int i = 0; i < phrasesCount; i++)
            {
                int eventsIndex = rnd.Next(0, events.Length);
                int phrasesIndex = rnd.Next(0, phrases.Length);
                int authorsIndex = rnd.Next(0, authors.Length);
                int citiesIndex = rnd.Next(0, cities.Length);

                string currentPhrase =
                    $"{phrases[phrasesIndex]} {events[eventsIndex]} {authors[authorsIndex]} - {cities[citiesIndex]}" +
                    Environment.NewLine;

                File.AppendAllText("output.txt", currentPhrase);
            }
        }
    }
}
