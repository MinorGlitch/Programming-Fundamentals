﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelrahShake
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = Console.ReadLine();

            while (pattern.Length > 0)
            {
                int firstIndex = input.IndexOf(pattern);
                int secondIndex = input.LastIndexOf(pattern);

                if (firstIndex >= 0 && secondIndex >= 0 || firstIndex != secondIndex)
                {
                    input = input.Remove(secondIndex, pattern.Length);
                    input = input.Remove(firstIndex, pattern.Length);

                    Console.WriteLine("Shaked it.");
                }
                else
                {
                    break;
                }

                pattern = pattern.Remove(pattern.Length / 2, 1);
            }

            Console.WriteLine("No shake.");

            Console.WriteLine(input);
        }
    }
}
