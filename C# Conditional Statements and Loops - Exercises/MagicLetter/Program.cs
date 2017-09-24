using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());
            char exclude = char.Parse(Console.ReadLine());

            string combination = null;

            for (char i = start; i <= end; i++)
            {
                for (char j = start; j <= end; j++)
                {
                    for (char k = start; k <= end; k++)
                    {
                        combination = $"{i}{j}{k}";

                        if (!combination.Contains(exclude))
                        {
                            Console.Write($"{combination} ");
                        }
                    }
                }
            }
        }
    }
}
