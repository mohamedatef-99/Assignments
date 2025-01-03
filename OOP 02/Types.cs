using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_02
{
    class TypeA
    {
        public int A { get; set; }

        public void Fun01()
        {
            Console.WriteLine("Fun01 from type A");
        }
        public virtual void Fun02()
        {
            Console.WriteLine($"A: {A}");
        }
    }

    class TypeB : TypeA
    {
        public int B { get; set; }
        public new void Fun01()
        {
            Console.WriteLine("Fun01 from type B");
        }
        public override void Fun02()
        {
            Console.WriteLine($"A: {A}, B: {B}");
        }
    }
    class TypeC : TypeB
    {
        public int C { get; set; }
        public new void Fun01()
        {
            Console.WriteLine("Fun01 from type C");
        }
        public override void Fun02()
        {
            Console.WriteLine($"A: {A}, B: {B}, C: {C}");
        }
    }

    class TypeD : TypeC
    {
        public int D { get; set; }
        public new void Fun01()
        {
            Console.WriteLine("Fun01 from type D");
        }
        public override void Fun02()
        {
            Console.WriteLine($"A: {A}, B: {B}, C: {C}, D: {D}");
        }
    }
}
