using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogsAggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, int>> aggregatedLogs = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < count; i++)
            {
                string[] log = Console.ReadLine().Split(' ');

                string name = log[1];

                int duration = int.Parse(log[2]);

                string ipAdress = log[0];

                if (!aggregatedLogs.ContainsKey(name))
                {
                    aggregatedLogs.Add(name, new Dictionary<string, int>());
                }

                AggregateLog(aggregatedLogs[name], duration, ipAdress);
            }

            PrintResult(aggregatedLogs);
        }

        private static void PrintResult(Dictionary<string, Dictionary<string, int>> aggregatedLogs)
        {
            foreach (KeyValuePair<string, Dictionary<string, int>> name in aggregatedLogs.OrderBy(x => x.Key))
            {
                Console.Write($"{name.Key}: ");
                Console.Write($"{name.Value.Values.Sum()} [{String.Join(", ", name.Value.Keys.OrderBy(x => x))}]");
                Console.WriteLine();
            }
        }

        private static void AggregateLog(Dictionary<string, int> aggregatedLog, int duration, string ipAdress)
        {
            if (!aggregatedLog.ContainsKey(ipAdress))
            {
                aggregatedLog.Add(ipAdress, duration);
            }
            else
            {
                aggregatedLog[ipAdress] += duration;
            }
        }
    }
}
