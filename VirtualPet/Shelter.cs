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

        }

        public Pet SelectPet()
        {
            int index = 1;

            Console.WriteLine("Please select your pet from the shelter:");
            foreach (Pet pet in ListOfPets)
            {
                Console.WriteLine($"{index}. {pet.Name} {pet.Species}");
                index++;
            }

            int indexSelected = Convert.ToInt32(Console.ReadLine());
            return ListOfPets[indexSelected - 1];
        }


    }
}
