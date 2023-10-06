using System;
using System.Collections.Generic;

namespace Task_1
{
    public class Ecosystem
    {
        private List<LivingOrganism> organisms = new List<LivingOrganism>();

        public void AddOrganism(LivingOrganism organism)
        {
            organisms.Add(organism);
        }

        public void SimulateEcosystem()
        {
            foreach (var organism in organisms)
            {
                Console.WriteLine($"Organism: {organism.GetType().Name}");
                Console.WriteLine($"Energy: {organism.Energy}");
                Console.WriteLine($"Age: {organism.Age}");
                Console.WriteLine($"Size: {organism.Size}");

                if (organism is IReproducible reproducible)
                {
                    reproducible.Reproduce();
                }

                if (organism is IPredator predator)
                {
                    predator.Hunt();
                }

             
                if (organism is Plant plant)
                {
                    Console.WriteLine($"Soil Type: {plant.SoilType}");
                }

                
                if (organism is Microorganism microorganism)
                {
                    Console.WriteLine($"Pulses Per Minute: {microorganism.PulsesPerMinute}");
                }

                Console.WriteLine();
            }
        }
    }
}