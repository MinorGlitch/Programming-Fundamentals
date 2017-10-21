using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> emailList = new Dictionary<string, string>();

            string name = Console.ReadLine();

            while (name != "stop")
            {
                string email = Console.ReadLine();

                if (!(email.EndsWith("us", StringComparison.OrdinalIgnoreCase)
                    || email.EndsWith("uk", StringComparison.OrdinalIgnoreCase)))
                {
                    emailList[name] = email;
                }

                name = Console.ReadLine();
            }

            foreach (KeyValuePair<string, string> person in emailList)
            {
                Console.WriteLine($"{person.Key} -> {person.Value}");
            }
        }
    }
}
