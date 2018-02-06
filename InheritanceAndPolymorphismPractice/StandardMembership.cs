using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphismPractice
{
    public class StandardMembership : Membership
    {
        // fields
        // invisible

        // properties
        public int Cost { get; set; } // does the same thing as the longer version, also creates that lower case cost field (it's just invisible)

        // constructors
        public StandardMembership()
        {
            // default constructor
        }

        public StandardMembership(int cost) // overloaded constructor
        {
            Cost = cost; // because the field is invisible, have to use the property Cost and set that equal to the parameter cost
        }

        // methods
        public override void Activate()
        {
            //base.Activate(); // does all the things in the base class activate methods
            //Console.WriteLine("You are a standard member.");

            if (IsActive == false)
            {
                IsActive = true;
                Console.WriteLine("Your standard membership has been activated.");
            }
            else
            {
                Console.WriteLine("Your standard membership is already active.");
            }

        }
    }
}
