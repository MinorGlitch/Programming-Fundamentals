using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheaThePhotographer
{
    class Program
    {
        static void Main(string[] args)
        {
            long picturesTaken = long.Parse(Console.ReadLine());
            long filterTimePerPicture = long.Parse(Console.ReadLine());
            long goodPicturesPercentage = long.Parse(Console.ReadLine());
            long uploadTimePerPicture = long.Parse(Console.ReadLine());

            double goodPictures = Math.Ceiling((picturesTaken * goodPicturesPercentage) / 100.0);

            double filterTime = picturesTaken * filterTimePerPicture;

            double uploadTime = goodPictures * uploadTimePerPicture;

            long totalTime = (long)(filterTime + uploadTime);

            TimeSpan timeTaken = TimeSpan.FromSeconds(totalTime);

            string formattedTime = timeTaken.ToString(@"d\:hh\:mm\:ss");

            Console.WriteLine(formattedTime);
        }
    }
}
