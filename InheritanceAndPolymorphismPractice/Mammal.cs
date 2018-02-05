using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphismPractice
{
    public class Mammal
    {
        // fields
        private string habitat;
        private double weight;
        private string furType;
        private bool domestication;

        // properties
        public string Habitat
        {
            get { return this.habitat; }
            set { this.habitat = value; }
        }

        public double Weight
        {
            get { return this.weight; }
            set { this.weight = value; }
        }

        // constructors

        public Mammal ()
        {
            // default constructor
        }

        public Mammal (string habitat, bool domestication)
        {
            this.habitat = habitat;
            this.domestication = domestication;
        }

        // methods

        public void IsDomesticated()
        {
            if (domestication == true)
            {
                habitat = "house";
            }
            else
            {
                // nothing is here
            }
        }


    }

}
