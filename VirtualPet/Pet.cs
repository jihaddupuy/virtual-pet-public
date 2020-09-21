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
        public string Hunger { get; set; }

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
        //public int GetHunger()
        //{
        //    int Hunger = 50;
        //}
        // Finished here
    }

    //public string SetName(string newName)
    //{
    //    string newName = "Fluffy";
    //    return newName;
    //}
}
