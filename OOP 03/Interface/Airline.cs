using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_03.Interface
{
    internal class Airline : IMoveable,IFlyable
    {
        int IMoveable.Speed { get ; set; }
        int IFlyable.Speed { get ; set; }

        void IMoveable.Backward()
        {
            Console.WriteLine("Airline IMovable");
        }

        void IMoveable.Forward()
        {
            Console.WriteLine("Airline IMovable");
        }

        void IMoveable.Left()
        {
            Console.WriteLine("Airline IMovable");
        }

        void IMoveable.Right()
        {
            Console.WriteLine("Airline IMovable");
        }
        void IFlyable.Backward()
        {
            Console.WriteLine("Airline IFlyable");
        }

        void IFlyable.Forward()
        {
            Console.WriteLine("Airline IFlyable");
        }

        void IFlyable.Left()
        {
            Console.WriteLine("Airline IFlyable");
        }

        void IFlyable.Right()
        {
            Console.WriteLine("Airline IFlyable");
        }
    }
}
