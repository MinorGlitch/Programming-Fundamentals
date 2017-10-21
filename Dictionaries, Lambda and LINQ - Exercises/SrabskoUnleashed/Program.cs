using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SrabskoUnleashed
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, Dictionary<string, int>> singersVenue = new Dictionary<string, Dictionary<string, int>>();

            string inputPattern = @"(([a-zA-Z]+\s){1,3})@(([a-zA-Z]+\s){1,3})(\d+)\s(\d+)";

            while (input != "End")
            {
                if (Regex.IsMatch(input, inputPattern))
                {
                    Match elements = Regex.Match(input, inputPattern);

                    string singer = elements.Groups[1].Value;

                    string venue = elements.Groups[3].Value;

                    int ticketsPrice = int.Parse(elements.Groups[5].Value);

                    int ticketsCount = int.Parse(elements.Groups[6].Value);

                    int totalMoney = ticketsCount * ticketsPrice;

                    if (!singersVenue.ContainsKey(venue))
                    {
                        singersVenue.Add(venue, new Dictionary<string, int>()
                        {
                            {
                                singer, totalMoney
                            }
                        });
                    }
                    else if (!singersVenue[venue].ContainsKey(singer))
                    {
                        singersVenue[venue].Add(singer, totalMoney);
                    }
                    else
                    {
                        singersVenue[venue][singer] += totalMoney;
                    }
                }

                input = Console.ReadLine();
            }

            foreach (KeyValuePair<string, Dictionary<string, int>> stage in singersVenue)
            {
                Console.WriteLine(stage.Key);

                foreach (KeyValuePair<string, int> singer in stage.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {singer.Key}-> {singer.Value}");
                }
            }
        }
    }
}
