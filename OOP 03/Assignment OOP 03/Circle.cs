using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_03.Assignment_OOP_03
{
    internal class Circle : ICircle, IShape
    {
        public double Radius { get; set; }
        public double Area
        {
            get
            {
                return Math.PI * Radius * Radius;
            }
            set;
        }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Circle - Radius: {Radius}, Area: {Area}");
        }
    }
}
