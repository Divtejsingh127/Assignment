using System;
using System.Threading;

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

        public void SimulateTimePassing()
        {
            // Simulate the passage of time
            while (true)
            {
                Thread.Sleep(5000); // Simulate an hour of time passing (in milliseconds)
                Hunger++;
                Happiness--;
                // You can add more time-based changes here
            }
        }

        // Other methods such as Feed, Play, Rest, DisplayStats, and StatusCheck can be included as in the previous examples
    }

    class Program
    {
        static void Main()
        {
            VirtualPet pet = new VirtualPet(" ");

            // Start simulating time-based changes in a separate thread
            Thread timeThread = new Thread(pet.SimulateTimePassing);
            timeThread.Start();

            // The rest of the program logic for user interaction and caring for the pet can be added here
        }
    }
}