using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resources = new Dictionary<string, int>();

            string item = Console.ReadLine();

            while (item != "stop")
            {
                int number = int.Parse(Console.ReadLine());

                if (resources.ContainsKey(item))
                {
                    resources[item] += number;
                }
                else
                {
                    resources[item] = number;
                }

                item = Console.ReadLine();
            }

            foreach (KeyValuePair<string, int> resource in resources)
            {
                Console.WriteLine($"{resource.Key} -> {resource.Value}");
            }
        }
    }
}
