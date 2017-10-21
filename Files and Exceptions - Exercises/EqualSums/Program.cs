using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            File.WriteAllText("input.txt", String.Empty);

            //Replace String.Empty with your input arguments.

            string arrArgs = File.ReadAllText("input.txt");

            int[] numbers = arrArgs.Split(' ').Select(int.Parse).ToArray();

            bool sumFound = false;

            File.WriteAllText("output.txt", String.Empty);

            for (int i = 0; i < numbers.Length; i++)
            {
                int[] leftSide = numbers.Take(i).ToArray();
                int[] rightSide = numbers.Skip(i + 1).ToArray();

                if (leftSide.Sum() == rightSide.Sum())
                {
                    File.WriteAllText("output.txt", i.ToString());
                    sumFound = true;

                    break;
                }
            }

            if (!sumFound)
            {
                File.WriteAllText("output.txt", "no");
            }
        }
    }
}
