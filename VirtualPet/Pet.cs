using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace VirtualPet
{
    public class Pet
    {       //  properties 
        public string Name { get; set;}
        // methods
        public void SetName(string name)
        {
            name = "Fluffy";
            Name = name;
        }

        public string GetName() 
        {
            return "Fido"; ///return variable instead of quotes
        }
      

    }

    //public string SetName(string newName)
    //{
    //    string newName = "Fluffy";
    //    return newName;
    //}
}
