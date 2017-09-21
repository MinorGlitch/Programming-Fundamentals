using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTable2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int multiplier = int.Parse(Console.ReadLine());
            int tableStartPoint = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine($"{multiplier} X {tableStartPoint} = {multiplier * tableStartPoint}");
                tableStartPoint++;
            } while (tableStartPoint <= 10);
        }
    }
}
