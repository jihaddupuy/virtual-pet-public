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

            Pet pet = new Pet();
            Console.WriteLine("Hello! Welcome to Virtual Pets\n");

            pet.AddPet();
            

            bool petChoice = true;
            while (petChoice)
            {
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
                        Console.WriteLine($"You fed/oiled {pet.GetName()}.");
                        pet.Tick();
                        break;
                    case "2":
                        pet.Play();
                        Console.WriteLine($"You and {pet.GetName()} played in the meadow together!");
                        pet.Tick();
                        break;
                    case "3": ///ad cw to show indication of what seeing the doctor does for your pet
                        pet.SeeDoctor();
                        Console.WriteLine($"You took {pet.GetName()} to the vet for health.");
                        pet.Tick();
                        break;
                    case "4":
                        pet.DisplayStatus();
                        break;
                    case "5":
                        petChoice = false;
                        break;
                    default:
                        Console.WriteLine("Invalid entry.");
                        break;
                }
                Console.WriteLine("Press Enter to continue.");
                Console.ReadKey();
                Console.Clear();
            }






        }
    }
}
