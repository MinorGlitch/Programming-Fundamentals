using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheatrePromotion
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfDay = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            int childrenTicketPrice = 0;
            int middleAgedTicketPrice = 0;
            int seniorsTicketPrice = 0;

            bool childrenGroup = age >= 0 && age <= 18;
            bool middleAgedGroup = age > 18 && age <= 64;
            bool seniorsGroup = age > 64 && age <= 122;

            switch (typeOfDay)
            {
                case "Weekday":
                    childrenTicketPrice = 12;
                    middleAgedTicketPrice = 18;
                    seniorsTicketPrice = 12;
                    break;
                case "Weekend":
                    childrenTicketPrice = 15;
                    middleAgedTicketPrice = 20;
                    seniorsTicketPrice = 15;
                    break;
                case "Holiday":
                    childrenTicketPrice = 5;
                    middleAgedTicketPrice = 12;
                    seniorsTicketPrice = 10;
                    break;
            }

            if (childrenGroup)
            {
                Console.WriteLine($"{childrenTicketPrice}$");
            }
            else if (middleAgedGroup)
            {
                Console.WriteLine($"{middleAgedTicketPrice}$");
            }
            else if (seniorsGroup)
            {
                Console.WriteLine($"{seniorsTicketPrice}$");
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
