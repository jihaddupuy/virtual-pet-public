using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace VirtualPet
{
    public class Pet
    {       //  properties 
        public string Name { get; set;}
        public string Species { get; set; }

        // methods
        public void SetName(string testPetName)
        {
            Name = testPetName;
            
        }

        public string GetName() 
        {
            return "Fido"; ///return variable instead of quotes
        }
        public void SetSpecies(string species)
        {
           
            species = "Cat";
            Species = species;
        }
    }

    //public string SetName(string newName)
    //{
    //    string newName = "Fluffy";
    //    return newName;
    //}
}
