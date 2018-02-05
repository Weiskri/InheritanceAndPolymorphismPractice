using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphismPractice
{
    class Rabbit : Mammal
    { // fields
        private string breed;
        private string furType;

        // properties
        public string Breed
        {
            get { return this.breed; }
            set { this.breed = value; }
        }

        // constructors
        public Rabbit(string breed) : base ("house", true)
        {
            this.breed = breed;
        }

        // methods

        public void Groom ()
        {
            furType = "neatly groomed";

        }

        public void Eat()
        {
            
        }
    }
}
