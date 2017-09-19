using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterStats
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int currentHealth = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());

            string healthLeft = new string('|', currentHealth);
            string leftToFullHealth = new string('.', maxHealth - currentHealth);

            string energyLeft = new string('|', currentEnergy);
            string leftToFullEnergy = new string('.', maxEnergy - currentEnergy);

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Health: |{healthLeft}{leftToFullHealth}|");
            Console.WriteLine($"Energy: |{energyLeft}{leftToFullEnergy}|");
        }
    }
}
