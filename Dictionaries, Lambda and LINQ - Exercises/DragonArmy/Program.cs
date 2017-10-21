using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonArmy
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfDragons = int.Parse(Console.ReadLine());

            var dragons = new Dictionary<string, SortedDictionary<string, List<int>>>();

            for (int i = 0; i < numberOfDragons; i++)
            {
                string[] dragonArgs = Console.ReadLine().Split(' ');

                string dragonColor = dragonArgs[0];

                if (!dragons.ContainsKey(dragonColor))
                {
                    dragons.Add(dragonColor, new SortedDictionary<string, List<int>>());
                }

                string dragonName = dragonArgs[1];

                int dragonDamage = dragonArgs[2] == "null" ? 45 : int.Parse(dragonArgs[2]);

                int dragonHealth = dragonArgs[3] == "null" ? 250 : int.Parse(dragonArgs[3]);

                int dragonArmor = dragonArgs[4] == "null" ? 10 : int.Parse(dragonArgs[4]);

                if (!dragons[dragonColor].ContainsKey(dragonName))
                {
                    dragons[dragonColor].Add(dragonName, new List<int>());

                    dragons[dragonColor][dragonName].Add(dragonDamage);
                    dragons[dragonColor][dragonName].Add(dragonHealth);
                    dragons[dragonColor][dragonName].Add(dragonArmor);
                }
                else
                {
                    dragons[dragonColor][dragonName].Clear();

                    dragons[dragonColor][dragonName].Add(dragonDamage);
                    dragons[dragonColor][dragonName].Add(dragonHealth);
                    dragons[dragonColor][dragonName].Add(dragonArmor);
                }
            }

            foreach (KeyValuePair<string, SortedDictionary<string, List<int>>> dragon in dragons)
            {
                double averageDamage = dragon.Value.Values.Average(value => value[0]);
                double averageHealth = dragon.Value.Values.Average(value => value[1]);
                double averageArmor = dragon.Value.Values.Average(value => value[2]);

                Console.WriteLine($"{dragon.Key}::({averageDamage:F2}/{averageHealth:F2}/{averageArmor:F2})");

                foreach (KeyValuePair<string, List<int>> dragonName in dragon.Value)
                {
                    Console.WriteLine(
                        $"-{dragonName.Key} -> damage: " +
                        $"{dragonName.Value[0]}, health: " +
                        $"{dragonName.Value[1]}, armor: " +
                        $"{dragonName.Value[2]}");
                }
            }
        }
    }
}
