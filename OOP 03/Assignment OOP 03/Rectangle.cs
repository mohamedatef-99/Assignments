using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_03.Assignment_OOP_03
{
    internal class Rectangle : IRectangle
    {
        public double Lenght { get; set; }
        public double Width { get; set; }
        public double Area
        {
            get 
            { 
                return Width * Lenght;
            } 
            set;
        }

        public Rectangle(double lenght, double width)
        {
            Lenght = lenght;
            Width = width;
        }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Rectangle - Width: {Width}, Height: {Lenght}, Area: {Area}");
        }
    }
}
