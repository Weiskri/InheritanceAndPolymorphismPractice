using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphismPractice
{
    public class Cat : Mammal
    {
        // fields
        // there aren't any here

        // properties
        // still nothing

        // constructor
        public Cat (string breed) : base ("house", true) // not inherited, but can reference
        {
            // nothing here either
        }

        // methods

        public void Eat()
        {
            
        }

        public string PetCat()
        {
            return "the cat purrs";
        }

        
    }
}
