using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonebookUpgrade
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arguments = Console.ReadLine().Split(' ').ToArray();

            SortedDictionary<string, string> phonebook = new SortedDictionary<string, string>();

            while (arguments[0] != "END")
            {
                switch (arguments[0])
                {
                    case "A":
                        {
                            AddToPhonebook(phonebook, arguments[1], arguments[2]);
                        }
                        break;
                    case "S":
                        {
                            SearchPhonebook(phonebook, arguments[1]);
                        }
                        break;
                    default:
                        {
                            PrintPhonebook(phonebook);
                        }
                        break;
                }

                arguments = Console.ReadLine().Split(' ').ToArray();
            }
        }

        static void PrintPhonebook(SortedDictionary<string, string> phonebook)
        {
            foreach (KeyValuePair<string, string> entry in phonebook)
            {
                Console.WriteLine($"{entry.Key} -> {entry.Value}");
            }
        }

        static void AddToPhonebook(SortedDictionary<string, string> phonebook, string name, string phoneNumber)
        {
            phonebook[name] = phoneNumber;
        }

        static void SearchPhonebook(SortedDictionary<string, string> phonebook, string name)
        {
            if (phonebook.ContainsKey(name))
            {
                Console.WriteLine($"{name} -> {phonebook[name]}");
            }
            else
            {
                Console.WriteLine($"Contact {name} does not exist.");
            }
        }
    }
}
