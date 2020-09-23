using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    public class Robotic : Pet
    {
        public int OilLevel { get; set; }

        public Robotic()
        {
            OilLevel = 50;
        }

        ///methods

        public override void SetName(string name)
        {
            Name = name;
        }

        public override string GetName()
        {
            return Name; ///return variable instead of quotes
        }
        
        public int GetOilLevel()
        {
            return OilLevel;
        }

        public override int GetBoredom()
        {
            return Boredom;
        }

        public override int GetHealth()
        {
            return Health;
        }
        public override void Feed()
        {
            OilLevel += 40; /// set up if/else statement for sufficient, depleting and critical oil levels with increments doing down
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
            Console.WriteLine($"Robotic {Name}:");
            Console.WriteLine($"Oil Level:{GetOilLevel()}, Boredom {GetBoredom()}, Robot Health {GetHealth()}.\n");
        }
    }


}
