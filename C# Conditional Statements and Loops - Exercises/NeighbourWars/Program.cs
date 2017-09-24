using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeighbourWars
{
    class Program
    {
        static void Main(string[] args)
        {
            int peshoDamage = int.Parse(Console.ReadLine());
            int goshoDamage = int.Parse(Console.ReadLine());

            int peshoHealth = 100;
            int goshoHealth = 100;

            string[] attacks = new string[2] { "Thunderous fist", "Roundhouse kick" };
            string[] players = new string[2] { "Gosho", "Pesho" };

            string currentPlayer = null;

            string defender = null;

            string winner = null;

            string currentAttack = null;

            int defenderHealth = 0;

            int turn = 0;

            while (true)
            {
                turn++;

                if (turn % 2 != 0)
                {
                    goshoHealth -= peshoDamage;
                    currentPlayer = players[1];
                    defender = players[0];
                    defenderHealth = goshoHealth;
                    currentAttack = attacks[1];
                }
                else
                {
                    peshoHealth -= goshoDamage;
                    currentPlayer = players[0];
                    defender = players[1];
                    defenderHealth = peshoHealth;
                    currentAttack = attacks[0];
                }

                if (goshoHealth <= 0 || peshoHealth <= 0)
                {
                    break;
                }

                Console.WriteLine($"{currentPlayer} used {currentAttack} and reduced {defender} to {defenderHealth} health.");

                if (turn % 3 == 0)
                {
                    goshoHealth += 10;
                    peshoHealth += 10;
                }
            }

            if (goshoHealth > 0)
            {
                winner = players[0];
            }
            else
            {
                winner = players[1];

            }

            Console.WriteLine($"{winner} won in {turn}th round.");
        }
    }
}
