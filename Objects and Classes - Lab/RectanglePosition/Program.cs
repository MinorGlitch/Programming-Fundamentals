using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectanglePosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rectangleValues = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Rectangle r1 = new Rectangle
            {
                Left = rectangleValues[0],
                Top = rectangleValues[1],
                Width = rectangleValues[2],
                Height = rectangleValues[3]
            };

            rectangleValues = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Rectangle r2 = new Rectangle
            {
                Left = rectangleValues[0],
                Top = rectangleValues[1],
                Width = rectangleValues[2],
                Height = rectangleValues[3]
            };

            string isInside = IsInside(r1, r2);

            Console.WriteLine(isInside);
        }

        static string IsInside(Rectangle r1, Rectangle r2)
        {
            List<bool> isInside = new List<bool>
            {
                r1.Left >= r2.Left,
                r1.Right <= r2.Right,
                r1.Top <= r2.Top,
                r1.Bottom <= r2.Bottom
            };

            if (isInside.Contains(false))
            {
                return "Not inside";
            }
            return "Inside";
        }

        class Rectangle
        {
            public int Top { get; set; }
            public int Left { get; set; }
            public int Width { get; set; }
            public int Height { get; set; }

            public int Bottom
            {
                get
                {
                    return Top + Height;
                }

            }

            public int Right
            {
                get
                {
                    return Left + Width;
                }
            }
        }
    }
}
