using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostFrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] count = new int[65536];

            foreach (int num in numbers)
            {
                count[num]++;
            }

            int maxValue = count.Max();

            foreach (int num in numbers)
            {
                if (count[num] == maxValue)
                {
                    Console.WriteLine(num);
                    return;
                }
            }
        }
    }
}
