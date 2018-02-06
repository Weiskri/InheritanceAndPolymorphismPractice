using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphismPractice
{
    public class VIPMembership : Membership
    {
        // fields
        // invisible

        // properties
        public bool IsSwanky { get; set; } // creates field isSwanky behind the scenes

        // constructors
        public VIPMembership()
        {
            // default constructor
        }
        public VIPMembership(bool isSwanky)
        {
            IsSwanky = isSwanky; // don't need "this" because one is lowercase and one is uppercase
        }

        // methods
        public override void Activate()
        {
            IsSwanky = true; // again, referencing the property because the field is incognito
            if (IsActive == false)
            {
                IsActive = true;
                Console.WriteLine("You are now a big deal.");
            }
            else
            {
                Console.WriteLine("You're already a big deal.");
            }
        }
    }
}
