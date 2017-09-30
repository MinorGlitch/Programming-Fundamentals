using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace CenturiesToNanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            byte centuries = byte.Parse(Console.ReadLine());

            int years = centuries * 100;

            int days = (int)(years * 365.2422);

            int hours = days * 24;

            int minutes = hours * 60;

            ulong seconds = (ulong)minutes * 60;

            ulong milliseconds = seconds * 1000;

            BigInteger microseconds = milliseconds * 1000;

            BigInteger nanoseconds = microseconds * 1000;

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = " +
                $"{milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
        }
    }
}
