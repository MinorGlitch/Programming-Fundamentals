using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputDate = Console.ReadLine();

            string dateFormat = "d-M-yyyy";

            DateTime date = DateTime.ParseExact(inputDate, dateFormat, CultureInfo.InvariantCulture);

            Console.WriteLine(date.DayOfWeek);
        }
    }
}
