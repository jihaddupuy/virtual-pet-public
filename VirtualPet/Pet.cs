using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace VirtualPet
{
    public class Pet
    {       //  properties 
        public string Name { get; set; }
        public string Species { get; set; }
        public int Hunger { get; set; }
        public int Boredom { get; set; }
        public int Health { get; set; }
        // constuctor
        public Pet()
        {
            Hunger = 50;
            Boredom = 60;
            Health = 30;
        }

        

        // methods
        public void SetName(string name)
        {
            Name = name;
        }

        public string GetName()
        {
            return Name; ///return variable instead of quotes
        }
        public void SetSpecies(string species)
        {
            Species = species;
        }
        public string GetSpecies()
        {
            return Species;
        }


        public int GetHunger()
        {
            return Hunger;
        }

        public int GetBoredom()
        {
            return Boredom;
        }

        public int GetHealth()
        {
            return Health;
        }
        public void Feed()
        {
            Hunger -= 40;
        }

        public void SeeDoctor()
        {
            Health += 30;
        }

        public void Play()
        {
            Hunger += 10;
        }
    }
}
