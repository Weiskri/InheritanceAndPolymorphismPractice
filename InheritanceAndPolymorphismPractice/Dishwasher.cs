using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphismPractice
{
    public class Dishwasher : Appliance
    {
        // fields
        // incognito

        // properties
        public double DecibelLevel { get; set; }
        public bool HasHeatDry { get; set; }

        // constructors
        public Dishwasher()
        {
            // default constructor
        }
        public Dishwasher (double decibelLevel, bool hasHeatDry)
        {
            DecibelLevel = decibelLevel;
            HasHeatDry = hasHeatDry;
        }

        // methods
        public override void Work()
        {
            Console.WriteLine("I wash your dishes.");
            Console.WriteLine("wash wash wash");
        }
    }
}
