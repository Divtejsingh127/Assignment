using System;

namespace Assignment
{
    record VirtualPet(string Name, int Hunger, int Happiness, int Health)
    {
        public VirtualPet(string name) : this(name, 5, 5, 5)
        {
        }

        public void DisplayStats()
        {
            Console.WriteLine("Pet's Stats:");
            Console.WriteLine("Hunger: " + Hunger);
            Console.WriteLine("Happiness: " + Happiness);
            Console.WriteLine("Health: " + Health);
        }

        public void StatusCheck()
        {
            if (Hunger <= 2 || Hunger >= 8)
            {
                Console.WriteLine("Warning: Pet's hunger is critically low or high!");
            }
            if (Happiness <= 2 || Happiness >= 8)
            {
                Console.WriteLine("Warning: Pet's happiness is critically low or high!");
            }
            if (Health <= 2 || Health >= 8)
            {
                Console.WriteLine("Warning: Pet's health is critically low or high!");
            }
        }
    }

    class Program
    {
        static void Main()
        {
            VirtualPet pet = new VirtualPet("Fido");
            pet.DisplayStats();
            pet.StatusCheck();
        }
    }
}