using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arguments = Console.ReadLine().Split(' ').ToArray();

            Dictionary<string, string> phonebook = new Dictionary<string, string>();

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
                        SearchPhonebook(phonebook, arguments[1]);
                        break;
                }

                arguments = Console.ReadLine().Split(' ').ToArray();
            }
        }

        static void AddToPhonebook(Dictionary<string, string> phonebook, string name, string phoneNumber)
        {
            phonebook[name] = phoneNumber;
        }

        static void SearchPhonebook(Dictionary<string, string> phonebook, string name)
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
