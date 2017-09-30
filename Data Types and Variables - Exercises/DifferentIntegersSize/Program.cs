using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferentIntegersSize
{
    class Program
    {
        enum DataTypes { @sbyte, @byte, @short, @ushort, @int, @uint, @long };

        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<DataTypes> types = new List<DataTypes>();

            if (sbyte.TryParse(input, out sbyte sb))
            {
                types.Add(DataTypes.@sbyte);
            }

            if (byte.TryParse(input, out byte bt))
            {
                types.Add(DataTypes.@byte);
            }

            if (short.TryParse(input, out short st))
            {
                types.Add(DataTypes.@short);
            }

            if (ushort.TryParse(input, out ushort ust))
            {
                types.Add(DataTypes.@ushort);
            }

            if (int.TryParse(input, out int it))
            {
                types.Add(DataTypes.@int);
            }

            if (uint.TryParse(input, out uint uit))
            {
                types.Add(DataTypes.@uint);
            }

            if (long.TryParse(input, out long lg))
            {
                types.Add(DataTypes.@long);
            }

            if (types.Count == 0)
            {
                Console.WriteLine($"{input} can't fit in any type");
                return;
            }

            Console.WriteLine($"{input} can fit in:");

            foreach (DataTypes type in types)
            {
                Console.WriteLine($"* {type}");
            }
        }
    }
}
