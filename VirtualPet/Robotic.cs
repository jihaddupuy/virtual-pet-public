using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{           
    public class Robotic : Pet
    { //properties
        public int OilLevel { get; set; }

        public string Robot { get; set; }
        
        /// constructor
        public Robotic()
        {
            OilLevel = 50;
        }

        public Robotic(string name, string species)
        {
            Name = name;
            Robot = species;
            OilLevel = 50;
            Boredom = 60;
            Health = 30;
        }

        public string GetRobot()
        {
            return Robot;
        }

        ///methods

        public int GetOilLevel()
        {
            return OilLevel;
        }

        public override void Feed()
        {
            OilLevel += 40;
            Console.WriteLine($"Your pet's {OilLevel} is sufficient");
        }

        public void SeeMechanic()
        {
            Health += 30;
        }

        public override void Play()
        {
            OilLevel -= 10;
            Boredom -= 20;
            Health += 10;
        }

        public override void Tick()
        {
            Health -= 5;
            Boredom += 5;
            OilLevel -= 5;
        }

        public override void DisplayStatus()
        {
            Console.WriteLine($"{GetRobot()} {Name}:");
            Console.WriteLine($"Oil Level:{GetOilLevel()}, Boredom {GetBoredom()}, Robot Health {GetHealth()}.\n");
        }
    }


}
