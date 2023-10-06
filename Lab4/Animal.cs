using System;
using Task_1;

namespace Task_1
{
    public class Animal : LivingOrganism, IReproducible, IPredator
    {
        public string Species { get; set; }
        public int NumberOfLegs { get; set; }
        public string FurColor { get; set; }
        public double Speed { get; set; } 

        public Animal(double energy, int age, double size, string species, int numberOfLegs, string furColor, double speed)
            : base(energy, age, size)
        {
            Species = species;
            NumberOfLegs = numberOfLegs;
            FurColor = furColor;
            Speed = speed; 
        }

        public void Reproduce()
        {
            Console.WriteLine($"The {Species} is reproducing.");
        }

        public void Hunt()
        {
            Console.WriteLine($"The {Species} is hunting.");
        }
    }
}