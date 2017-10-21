using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostFrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            File.WriteAllText("input.txt", String.Empty);

            //Replace String.Empty with your input arguments.

            string input = File.ReadAllText("input.txt");

            int[] numbers = input.Split(' ').Select(int.Parse).ToArray();

            int[] count = new int[65536];

            File.WriteAllText("output.txt", String.Empty);

            foreach (int num in numbers)
            {
                count[num]++;
            }

            int maxValue = count.Max();

            foreach (int num in numbers)
            {
                if (count[num] == maxValue)
                {
                    File.WriteAllText("output.txt", num.ToString());
                    return;
                }
            }
        }
    }
}
