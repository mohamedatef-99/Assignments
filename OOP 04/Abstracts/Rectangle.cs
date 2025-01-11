using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_04.Abstracts
{
    internal class Rectangle : Shape /* Implement and inhert from shape*/
    {
        public override double Perimeter
        {
            get
            {
                return (Dim01 * Dim02) *2;
            }
        }

        public override double GetArea()
        {
            return Dim01 * Dim02;
        }
    }
}
