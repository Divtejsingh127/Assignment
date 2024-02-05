using System;

namespace Assignment
{
    class VirtualPet
    {
        public string Name { get; set; }
        public int Hunger { get; set; }
        public int Happiness { get; set; }
        public int Health { get; set; }

        public VirtualPet(string name)
        {
            Name = name;
            Hunger = 5;
            Happiness = 5;
            Health = 5;
        }

        public void Feed()
        {
            Hunger -= 2;
            if (Hunger < 0)
            {
                Hunger = 0;
            }
            Health++;
        }

        public void Play()
        {
            if (Hunger < 5)
            {
                Console.WriteLine("I'm too hungry to play!");
            }
            else
            {
                Happiness += 3;
                if (Happiness > 10)
                {
                    Happiness = 10;
                }
                Hunger += 2;
                if (Hunger > 10)
                {
                    Hunger = 10;
                }
            }
        }

        public void Rest()
        {
            if (Hunger < 3)
            {
                Console.WriteLine("I'm too hungry to rest!");
            }
            else
            {
                Health += 2;
                if (Health > 10)
                {
                    Health = 10;
                }
                Hunger++;
            }
        }

        public void DisplayStats()
        {
            Console.WriteLine("Pet's Stats:");
            Console.WriteLine("Hunger: " + Hunger);
            Console.WriteLine("Happiness: " + Happiness);
            Console.WriteLine("Health: " + Health);
        }
    }

    class Program
    {
        static void Main()
        {
            VirtualPet pet = new VirtualPet("Fido");

            // Interact with the pet
            pet.Feed();
            pet.Play();

            // Display pet's stats
            pet.DisplayStats();
        }
    }
}