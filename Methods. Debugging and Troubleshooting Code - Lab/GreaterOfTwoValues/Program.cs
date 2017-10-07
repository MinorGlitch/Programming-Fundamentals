using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfVariables = Console.ReadLine();

            switch (typeOfVariables)
            {
                case "int":
                    int firstNumber = int.Parse(Console.ReadLine());
                    int secondNumber = int.Parse(Console.ReadLine());

                    int greaterNumber = GetMax(firstNumber, secondNumber);

                    Console.WriteLine(greaterNumber);
                    break;
                case "char":
                    char firstChar = char.Parse(Console.ReadLine());
                    char secondChar = char.Parse(Console.ReadLine());

                    char greaterChar = GetMax(firstChar, secondChar);

                    Console.WriteLine(greaterChar);
                    break;
                case "string":
                    string firstString = Console.ReadLine();
                    string secondString = Console.ReadLine();

                    string greaterString = GetMax(firstString, secondString);

                    Console.WriteLine(greaterString);
                    break;
            }
        }

        static int GetMax(int firstNumber, int secondNumber)
        {
            if (firstNumber >= secondNumber)
            {
                return firstNumber;
            }
            return secondNumber;
        }

        static char GetMax(char firstChar, char secondChar)
        {
            if (firstChar >= secondChar)
            {
                return firstChar;
            }
            return secondChar;
        }

        static string GetMax(string firstString, string secondString)
        {
            if (firstString.CompareTo(secondString) >= 0)
            {
                return firstString;
            }
            return secondString;
        }
    }
}
