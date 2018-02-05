using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphismPractice
{
    public class Rectangle : Shape
    {
        // fields
        private double area;

        // properties
        public double Area
        {
            get { return this.area; }
            set { this.area = value; }
        }
        
        // a derived class does not inherit the constructors of the base class
        // but, constructors of the base class can be accessed using the base keyword.

        // constructors
        public Rectangle(double area) : base(4) // this is accessing the shape class sides constructor and setting sides equal to 4
        {
            this.area = area;
        }

        // methods
    }
}
