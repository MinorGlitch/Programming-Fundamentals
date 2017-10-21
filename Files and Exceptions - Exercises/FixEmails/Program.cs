using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            File.WriteAllText("input.txt", String.Empty);

            //Replace String.Empty with your input arguments.

            List<string> inputSequence = File.ReadAllLines("input.txt").ToList();

            Dictionary<string, string> emailList = new Dictionary<string, string>();

            string name = inputSequence[0];

            while (name != "stop")
            {
                string email = inputSequence[1];

                if (!(email.EndsWith("us", StringComparison.OrdinalIgnoreCase)
                      || email.EndsWith("uk", StringComparison.OrdinalIgnoreCase)))
                {
                    emailList[name] = email;
                }

                inputSequence.RemoveRange(0, 2);

                name = inputSequence[0];
            }

            File.WriteAllText("output.txt", String.Empty);

            foreach (KeyValuePair<string, string> person in emailList)
            {
                string currentOutput = $"{person.Key} -> {person.Value}" + Environment.NewLine;

                File.AppendAllText("output.txt", currentOutput);
            }
        }
    }
}
