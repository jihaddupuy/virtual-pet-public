using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;

namespace VirtualPet
{
    class Program
    {

        static void Main(string[] args)
        {
            Shelter shelter = new Shelter();

            Pet pet = new Pet();

            List<Pet> ListOfPets = new List<Pet>();

            Console.WriteLine("Hello! Welcome to Virtual Pets\n");

            bool petChoice = true;
            while (petChoice)
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("NOTE: If you do not have a pet, please create one!");
                Console.WriteLine("1. Create a new organic pet");
                Console.WriteLine("2. Create a new robotic pet");
                Console.WriteLine("3. Display each pet status"); // add new menu option
                Console.WriteLine("4. Feed your Pet");
                Console.WriteLine("5. Play with your Pet");
                Console.WriteLine("6. Attend To Pet Health");
                Console.WriteLine("7. Quit");
                
                string menuChoice = Console.ReadLine();
                switch (menuChoice)
                {
                    case "1":
                        Console.WriteLine("What is the name for your organic pet?");
                        string name = Console.ReadLine();
                        Console.WriteLine("What species is your organic pet?");
                        string species = Console.ReadLine();
                        pet = new Organic(name, species);
                        shelter.AddPet(pet);
                        Console.ReadKey();
                        break;
                    case "2":
                         Console.WriteLine("What is the name of your robotic pet?");
                        name = Console.ReadLine();
                        species = "Robot";
                        pet = new Robotic(name, species);
                        shelter.AddPet(pet);
                        Console.ReadKey();
                        break;
                    case "3":
                        foreach (Pet selectedPet in shelter.ListOfPets)
                        {
                            selectedPet.DisplayStatus();
                        }
                        Console.ReadKey();
                        break;
                    case "4":
                        pet.Feed();
                        Console.WriteLine($"You fed/oiled {pet.GetName()}.");
                        pet.Tick();
                        break;
                    case "5":
                        pet.Play();
                        Console.WriteLine($"You and {pet.GetName()} played in the meadow together!");
                        pet.Tick();
                        break;
                    case "6":
                        pet.AttendToPetHealth();
                        Console.WriteLine($"You took {pet.GetName()} to the vet for health.");
                        pet.Tick();
                        break;
                    case "7":
                        petChoice = false;
                        break;
                    default:
                        Console.WriteLine("Invalid entry.");
                        break;
                }
                Console.WriteLine("Press Enter to continue.");
                Console.ReadKey();
                Console.Clear();
                ///ConsoleKeyInfo keyInfo = Console.ReadKey();
                ///while (keyInfo.Key != ConsoleKey.Enter)
                   ///keyInfo = Console.ReadKey();
            }






        }
    }
}
