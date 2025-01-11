using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_04.Abstracts
{
    // Abstract class : partial class [Not fully implemented class]
    // concert class : full implmented class
    internal abstract class Shape
    {
        public double Dim01 { get; set; }
        public double Dim02 { get; set; }

        // Abstract Method : like virtual method without implementation
        public abstract double GetArea();

        // Abstract Property : like virtual property without implementation
        public abstract double Perimeter { get; }

        public void print()
        {
            Console.WriteLine("iam shape");
        }
    }
}
