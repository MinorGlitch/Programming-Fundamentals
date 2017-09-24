using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double studio = 0d;
            double doubleRoom = 0d;
            double suite = 0d;

            double tempStudio = 0d;

            bool studioMonths = month == "May" || month == "October";
            bool doubleMonths = month == "June" || month == "September";
            bool suiteMonths = month == "July" || month == "August" || month == "December";

            var freeNight = month == "September" || month == "October";

            if (studioMonths)
            {
                studio = 50;
                doubleRoom = 65;
                suite = 75;

                if (nights > 7)
                {
                    studio -= studio * 0.05;
                    tempStudio = studio;
                }
            }
            else if (doubleMonths)
            {
                studio = 60;
                doubleRoom = 72;
                suite = 82;

                if (nights > 14)
                {
                    doubleRoom -= doubleRoom * 0.1;

                }
                else
                {
                    tempStudio = studio;
                }
            }
            else if (suiteMonths)
            {
                studio = 68;
                doubleRoom = 77;
                suite = 89;
                if (nights > 14)
                {
                    suite -= suite * 0.15;
                }
            }

            studio *= nights;
            doubleRoom *= nights;
            suite *= nights;

            if (freeNight && nights > 7)
            {
                studio -= tempStudio;
            }

            Console.WriteLine($"Studio: {studio:F2} lv.");
            Console.WriteLine($"Double: {doubleRoom:F2} lv.");
            Console.WriteLine($"Suite: {suite:F2} lv.");
        }
    }
}

