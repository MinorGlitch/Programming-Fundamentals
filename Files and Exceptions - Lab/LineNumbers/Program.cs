using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] allLines = File.ReadAllLines("input.txt");

            List<string> numeratedLines = new List<string>();

            for (int i = 0; i < allLines.Length; i++)
            {
                numeratedLines.Add($"{i + 1}. {allLines[i]}");
            }

            File.WriteAllLines("numeratedLines.txt", numeratedLines);
        }
    }
}
