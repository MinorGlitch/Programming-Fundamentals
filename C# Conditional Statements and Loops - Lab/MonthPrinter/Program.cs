using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonthPrinter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] months = new string[12] { "January", "February", "March", "April", "May", "June", "July",
                "August", "September", "October", "November", "December" };

            int month = int.Parse(Console.ReadLine());

            if (month > 12 || month < 1)
            {
                Console.WriteLine("Error!");
                return;
            }
            else
            {
                Console.WriteLine(months[month - 1]);
            }
        }
    }
}
