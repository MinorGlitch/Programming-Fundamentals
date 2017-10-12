using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            SortedDictionary<double, int> numbersCount = new SortedDictionary<double, int>();

            foreach (double key in numbers)
            {
                if (numbersCount.ContainsKey(key))
                {
                    numbersCount[key]++;
                }
                else
                {
                    numbersCount[key] = 1;
                }
            }

            foreach (KeyValuePair<double, int> occurrence in numbersCount)
            {
                Console.WriteLine($"{occurrence.Key} -> {occurrence.Value}");
            }
        }
    }
}
