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







        }
    }
}
