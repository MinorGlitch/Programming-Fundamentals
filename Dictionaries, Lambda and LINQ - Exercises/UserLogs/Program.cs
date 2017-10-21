using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogs
{
    class Program
    {
        static void Main(string[] args)
        {
            var messagesCount = new SortedDictionary<string, Dictionary<string, int>>();

            char[] delimiters = { ' ', '=' };

            string[] input = Console.ReadLine().Split(delimiters);

            while (input[0] != "end")
            {
                string ipAdress = input[1];

                string name = input[input.Length - 1];

                if (!messagesCount.ContainsKey(name))
                {
                    messagesCount.Add(name, new Dictionary<string, int>());
                }

                CountMessages(messagesCount[name], ipAdress);

                input = Console.ReadLine().Split(delimiters);
            }

            foreach (KeyValuePair<string, Dictionary<string, int>> entry in messagesCount)
            {
                Console.WriteLine($"{entry.Key}:");

                foreach (KeyValuePair<string, int> log in entry.Value)
                {
                    if (log.Equals(entry.Value.Last()))
                    {
                        Console.Write($"{log.Key} => {log.Value}.");
                    }
                    else
                    {
                        Console.Write($"{log.Key} => {log.Value}, ");
                    }
                }
                Console.WriteLine();
            }
        }

        private static void CountMessages(Dictionary<string, int> user, string ipAdress)
        {
            if (!user.ContainsKey(ipAdress))
            {
                user.Add(ipAdress, 1);
            }
            else
            {
                user[ipAdress]++;
            }
        }
    }
}
