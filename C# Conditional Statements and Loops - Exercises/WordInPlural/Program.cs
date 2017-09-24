﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordInPlural
{
    class Program
    {
        static void Main(string[] args)
        {
            string noun = Console.ReadLine();

            if (noun.EndsWith("y"))
            {
                noun = noun.Remove(noun.Length - 1, 1);
                noun += "ies";
            }
            else if (noun.EndsWith("o") || noun.EndsWith("ch") || noun.EndsWith("s")
                || noun.EndsWith("sh") || noun.EndsWith("x") || noun.EndsWith("z"))
            {
                noun += "es";
            }
            else
            {
                noun += "s";
            }

            Console.WriteLine(noun);
        }
    }
}
