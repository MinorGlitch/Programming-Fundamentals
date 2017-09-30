using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            string hello = "Hello";
            string world = "World";

            object concatenate = hello + " " + world;

            string output = (string)concatenate;

            Console.WriteLine(output);
        }
    }
}
