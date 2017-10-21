using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(':');

            Dictionary<string, Dictionary<string, int>> people = new Dictionary<string, Dictionary<string, int>>();

            while (input[0] != "JOKER")
            {
                string name = input[0];

                string[] cards = input[1].Trim().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

                if (!people.ContainsKey(name))
                {
                    people.Add(name, new Dictionary<string, int>());

                    AddCardsToPerson(people[name], cards);
                }

                AddCardsToPerson(people[name], cards);

                input = Console.ReadLine().Split(':');
            }

            foreach (KeyValuePair<string, Dictionary<string, int>> hand in people)
            {
                Console.WriteLine($"{hand.Key}: {hand.Value.Values.Sum()}");
            }
        }

        private static void AddCardsToPerson(Dictionary<string, int> person, string[] cards)
        {
            foreach (string card in cards)
            {
                if (!person.ContainsKey(card))
                {
                    person.Add(card, GetCardSum(card));
                }
            }
        }

        private static int GetCardSum(string card)
        {
            int sum = 0;

            switch (card[0])
            {
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                    sum += card[0] - 48;
                    break;
                case '1':
                    sum += 10;
                    break;
                case 'J':
                    sum += 11;
                    break;
                case 'Q':
                    sum += 12;
                    break;
                case 'K':
                    sum += 13;
                    break;
                case 'A':
                    sum += 14;
                    break;
            }

            switch (card[card.Length - 1])
            {
                case 'S':
                    sum *= 4;
                    break;
                case 'H':
                    sum *= 3;
                    break;
                case 'D':
                    sum *= 2;
                    break;
                case 'C':
                    sum *= 1;
                    break;
            }

            return sum;
        }
    }
}
