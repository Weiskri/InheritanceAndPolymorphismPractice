using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphismPractice
{
    public abstract class Appliance
    {
        // fields
        private bool isElectric;

        //properties
        public bool IsElectric
        {
            get { return this.isElectric; }
            set { this.isElectric = value; }
        }

        // constructors -- never instantiated so no constructors
        // none

        // methods
        public abstract void Work();
    }
}
