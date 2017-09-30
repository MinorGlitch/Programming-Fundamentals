using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertSpeedUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            int distanceInMeters = int.Parse(Console.ReadLine());

            int hours = int.Parse(Console.ReadLine());

            int minutes = int.Parse(Console.ReadLine());

            int seconds = int.Parse(Console.ReadLine());

            int totalTimeInSeconds = (hours * 3600) + (minutes * 60) + seconds;

            float metresPerSecond = (float)distanceInMeters / totalTimeInSeconds;

            float kilometersPerHour = (distanceInMeters / 1000) / (totalTimeInSeconds / 3600F);

            float milesPerHour = (distanceInMeters / 1609F) / (totalTimeInSeconds / 3600F);

            Console.WriteLine(metresPerSecond);
            Console.WriteLine(kilometersPerHour);
            Console.WriteLine(milesPerHour);
        }
    }
}
