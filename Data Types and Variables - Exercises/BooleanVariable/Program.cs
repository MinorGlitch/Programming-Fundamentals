using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            string trueOrFalse = Console.ReadLine();

            bool yesOrNo = Convert.ToBoolean(trueOrFalse);

            switch (yesOrNo)
            {
                case true:
                    Console.WriteLine("Yes");
                    break;
                case false:
                    Console.WriteLine("No");
                    break;
            }
        }
    }
}
