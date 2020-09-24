using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    public class Organic : Pet
    {
        public Organic() : base()
        {

        }

        public Organic(string name, string species)
        {
            Name = name;
            Species = species;
            Hunger = 50;
            Boredom = 60;
            Health = 30;
        }
    }
}
