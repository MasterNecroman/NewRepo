﻿using System;

namespace Task_1
{
    public interface IReproducible
    {
        void Reproduce();
    }

    public interface IPredator
    {
        void Hunt();
    }

    public class LivingOrganism
    {
        public double Energy { get; set; }
        public int Age { get; set; }
        public double Size { get; set; }

        public LivingOrganism(double energy, int age, double size)
        {
            Energy = energy;
            Age = age;
            Size = size;
        }
    }
}