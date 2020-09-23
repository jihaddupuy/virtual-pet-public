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
        public virtual void SetName(string name)
        {
            Name = name;
        }

        public virtual string GetName()
        {
            return Name; ///return variable instead of quotes
        }
        public virtual void SetSpecies(string species)
        {
            Species = species;
        }
        public virtual string GetSpecies()
        {
            return Species;
        }


        public virtual int GetHunger()
        {
            return Hunger;
        }

        public virtual int GetBoredom()
        {
            return Boredom;
        }
        
        public virtual int GetHealth()
        {
            return Health;
        }
        public virtual void Feed()
        {
            Hunger -= 40;
        }

        public virtual void SeeDoctor()
        {
            Health += 30;
        }

        public virtual void Play()
        {
            Hunger += 10;
            Boredom -= 20;
            Health += 10;
        }

        public virtual void Tick()
        {
            Health -= 5;
            Boredom += 5;
            Hunger += 5;
        }

        public virtual void DisplayStatus()
        {
            Console.WriteLine($"{Name} the {Species}:");
            Console.WriteLine($"Hunger:{GetHunger()}, Boredom {GetBoredom()}, Pet Health {GetHealth()}.\n");
        }
    }
}
