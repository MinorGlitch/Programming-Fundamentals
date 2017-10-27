using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountWorkingDays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<DateTime> holidays = new List<DateTime>
            {
                DateTime.ParseExact("01-01-1970", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("03-03-1970", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("01-05-1970", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("06-05-1970", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("24-05-1970", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("06-09-1970", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("22-09-1970", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("01-11-1970", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("24-12-1970", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("25-12-1970", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("26-12-1970", "dd-MM-yyyy", CultureInfo.InvariantCulture)
            };

            DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);

            int workingDays = 0;

            for (DateTime i = startDate; i <= endDate; i = i.AddDays(1))
            {
                if (i.DayOfWeek != DayOfWeek.Saturday && i.DayOfWeek != DayOfWeek.Sunday)
                {
                    bool isNotHoliday = true;

                    foreach (DateTime holiday in holidays)
                    {
                        if (i.Day == holiday.Day && i.Month == holiday.Month)
                        {
                            isNotHoliday = false;
                            break;
                        }
                    }

                    if (isNotHoliday)
                    {
                        workingDays++;
                    }
                }
            }

            Console.WriteLine(workingDays);
        }
    }
}
