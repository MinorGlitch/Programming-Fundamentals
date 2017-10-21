using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddLines
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] allLines = File.ReadAllLines("input.txt");

            List<string> oddLines = new List<string>();

            for (int i = 0; i < allLines.Length; i++)
            {
                if (i % 2 != 0)
                {
                    oddLines.Add(allLines[i]);
                }
            }

            File.WriteAllLines("oddLines.txt", oddLines);
        }
    }
}
