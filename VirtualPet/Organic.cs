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

        public override void SetName(string name)
        {
            Name = name;
        }

        public override string GetName()
        {
            return Name; ///return variable instead of quotes
        }
        public override void SetSpecies(string species)
        {
            Species = species;
        }
        public override string GetSpecies()
        {
            return Species;
        }


        public override int GetHunger()
        {
            return Hunger;
        }

        public override int GetBoredom()
        {
            return Boredom;
        }

        public override int GetHealth()
        {
            return Health;
        }
        public override void Feed()
        {
            Hunger -= 40;
        }

        public override void SeeDoctor()
        {
            Health += 30;
        }

        public override void Play()
        {
            Hunger += 10;
            Boredom -= 20;
            Health += 10;
        }

        public override void Tick()
        {
            Health -= 5;
            Boredom += 5;
            Hunger += 5;
        }

        public override void DisplayStatus()
        {
            Console.WriteLine($"{Name} the {Species}:");
            Console.WriteLine($"Hunger:{GetHunger()}, Boredom {GetBoredom()}, Pet Health {GetHealth()}.\n");
        }
    }
}
