using System;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;

namespace VirtualPet
{
    class Program
    {

        static void Main(string[] args)
        {
            //what is the species of your pet?

            //pet name=petname
            //while //tic? status
            //what do you want to do
            //1 feed
            //2
            //3
            //4
            //switch()
            //{

            //} 
            Pet pet = new Pet();
            Console.WriteLine("Hello! Welcome to Virtual Pets");

            Console.WriteLine("What is the name of your pet?");
            string name = Console.ReadLine();
            pet.SetName(name);
            //Console.WriteLine(pet.GetName());

            Console.WriteLine("What species is your pet?");
            string species = Console.ReadLine();
            pet.SetSpecies(species);

            bool petChoice = true;
            while (petChoice)
            {
                // Add console clear
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. Feed your Pet");
                Console.WriteLine("2. Play with your Pet");
                Console.WriteLine("3. Take your Pet to the doctor");
                Console.WriteLine("4. Check your Pet's status");
                Console.WriteLine("5. Quit");


                string menuChoice = Console.ReadLine();
                switch (menuChoice)
                {
                    case "1":
                        pet.Feed();
                        break;
                    case "2":
                        pet.Play();
                        break;
                    case "3":
                        pet.SeeDoctor();
                        break;
                    case "4":
                        // Add names to statuses.
                        Console.WriteLine($"{pet.GetHunger()}, {pet.GetBoredom()}, {pet.GetHealth()}.");
                        break;
                    case "5":
                        petChoice = false;
                        break;
                    default:
                        Console.WriteLine("Invalid entry.");
                        break;
                }
            }






        }
    }
}
