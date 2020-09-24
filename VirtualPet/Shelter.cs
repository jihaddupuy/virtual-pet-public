using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    public class Shelter
    {
        public List<Pet> ListOfPets = new List<Pet>();


        public void AddPet(Pet pet)
        {
            ListOfPets.Add(pet);
            //Console.WriteLine("What is the name of your pet?\n");
            //string name = Console.ReadLine();
            //SetName(name);

            //Console.WriteLine("What species is your pet?\n");
            //string species = Console.ReadLine();
            //SetSpecies(species);

            //DisplayStatus();
        }



    }
}
