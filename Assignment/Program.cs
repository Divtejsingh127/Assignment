using System;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Virtual Pet!");

            Console.WriteLine("Choose a pet type (cat, dog, rabbit): ");
            string petType = Console.ReadLine();
            Console.WriteLine("Enter a name for your pet: ");
            string petName = Console.ReadLine();

            Pet myPet = new Pet(petType, petName);

            Console.WriteLine($"Congratulations! You have a new {myPet.PetType} named {myPet.PetName}.");

            bool exit = false;
           
         }
    }
}

