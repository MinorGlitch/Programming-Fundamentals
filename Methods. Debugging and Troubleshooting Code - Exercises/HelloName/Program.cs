using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloName
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            string greeting = Hello(name);

            Console.WriteLine(greeting);
        }

        static string Hello(string name)
        {
            return $"Hello, {name}!";
        }
    }
}
