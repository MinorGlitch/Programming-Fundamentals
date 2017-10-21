using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> keyItems = new Dictionary<string, int>();
            Dictionary<string, int> junkItems = new Dictionary<string, int>();

            keyItems.Add("shards", 0);
            keyItems.Add("fragments", 0);
            keyItems.Add("motes", 0);

            while (true)
            {
                List<string> inputArgs = Console.ReadLine().Split(' ').ToList();

                while (inputArgs.Count > 0)
                {
                    int materialQuantity = int.Parse(inputArgs[0]);

                    string currentMaterial = inputArgs[1].ToLower();

                    inputArgs.RemoveRange(0, 2);

                    SortMaterial(currentMaterial, materialQuantity, keyItems, junkItems);

                    if (EnoughItems(keyItems))
                    {
                        break;
                    }
                }

                if (EnoughItems(keyItems))
                {
                    break;
                }
            }

            PrintResult(keyItems, junkItems);
        }

        private static void PrintResult(Dictionary<string, int> keyItems, Dictionary<string, int> junkItems)
        {
            string legendaryItem = GetLegendaryItem(keyItems);

            Console.WriteLine($"{legendaryItem} obtained!");

            foreach (KeyValuePair<string, int> item in keyItems.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            foreach (KeyValuePair<string, int> item in junkItems.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }

        private static string GetLegendaryItem(Dictionary<string, int> keyItems)
        {
            foreach (KeyValuePair<string, int> item in keyItems)
            {
                if (item.Key == "shards" && item.Value >= 250)
                {
                    keyItems["shards"] -= 250;

                    return "Shadowmourne";
                }

                if (item.Key == "fragments" && item.Value >= 250)
                {
                    keyItems["fragments"] -= 250;

                    return "Valanyr";
                }

                if (item.Key == "motes" && item.Value >= 250)
                {
                    keyItems["motes"] -= 250;

                    return "Dragonwrath";
                }
            }

            return null;
        }

        private static bool EnoughItems(Dictionary<string, int> keyItems)
        {
            foreach (KeyValuePair<string, int> item in keyItems)
            {
                if (item.Value >= 250)
                {
                    return true;
                }
            }

            return false;
        }

        private static void SortMaterial(string currentMaterial, int materialQuantity, Dictionary<string, int> keyItems, Dictionary<string, int> junkItems)
        {
            string[] keyMaterials = { "shards", "fragments", "motes" };

            if (keyMaterials.Contains(currentMaterial))
            {
                keyItems[currentMaterial] += materialQuantity;
            }
            else
            {
                if (!junkItems.ContainsKey(currentMaterial))
                {
                    junkItems.Add(currentMaterial, materialQuantity);
                }
                else
                {
                    junkItems[currentMaterial] += materialQuantity;
                }
            }
        }
    }
}
