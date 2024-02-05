using System;

namespace PetCareApp
{
    class Program
    {
        static int hunger = 50; // Initial hunger level
        static int happiness = 50; // Initial happiness level
        static int health = 50; // Initial health level

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Virtual Pet Care!");

            while (true)
            {
                Console.WriteLine("\nWhat would you like to do?");
                Console.WriteLine("1. Feed your pet");
                Console.WriteLine("2. Play with your pet");
                Console.WriteLine("3. Rest your pet");
                Console.WriteLine("4. Quit the game");

                int choice;
                bool isValidChoice = int.TryParse(Console.ReadLine(), out choice);

                if (!isValidChoice || choice < 1 || choice > 4)
                {
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                    continue;
                }

                if (choice == 4)
                {
                    Console.WriteLine("Thanks for playing! Goodbye.");
                    break;
                }

                PerformAction(choice);
                DisplayStats();
            }
        }

        static void PerformAction(int action)
        {
            if (action == 1) // Feed the pet
            {
                hunger -= 20;
                health += 10;
                Console.WriteLine("You fed your pet. Hunger decreased and health slightly increased.");
            }
            else if (action == 2) // Play with the pet
            {
                happiness += 20;
                hunger += 10;
                Console.WriteLine("You played with your pet. Happiness increased and hunger slightly increased.");
            }
            else if (action == 3) // Rest the pet
            {
                health += 20;
                happiness -= 10;
                Console.WriteLine("You rested your pet. Health improved and happiness slightly decreased.");
            }
        }

        static void DisplayStats()
        {
            Console.WriteLine("\nCurrent Pet Stats:");
            Console.WriteLine("Hunger Level: " + hunger);
            Console.WriteLine("Happiness Level: " + happiness);
            Console.WriteLine("Health Level: " + health);
        }
    }
}


