using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            File.WriteAllText("input.txt", String.Empty);

            //Replace String.Empty with your input arguments.

            List<string> inputSequence = File.ReadAllLines("input.txt").ToList();

            Dictionary<string, int> resources = new Dictionary<string, int>();

            string item = inputSequence[0];

            while (item != "stop")
            {
                int number = int.Parse(inputSequence[1]);

                if (resources.ContainsKey(item))
                {
                    resources[item] += number;
                }
                else
                {
                    resources[item] = number;
                }

                inputSequence.RemoveRange(0, 2);

                item = inputSequence[0];
            }

            File.WriteAllText("output.txt", String.Empty);

            foreach (KeyValuePair<string, int> resource in resources)
            {
                string currentOutput = $"{resource.Key} -> {resource.Value}" + Environment.NewLine;

                File.AppendAllText("output.txt", currentOutput);
            }
        }
    }
}
