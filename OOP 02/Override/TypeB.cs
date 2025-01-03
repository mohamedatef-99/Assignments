using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_02.Override
{
    internal class TypeB : TypeA
    {
        public int B { get; set; }

        // override  or hide
        // apply override 
        // 1. Apply override using 'new' keyword ==> is the default 
        // 2. Apply override using 'override' keyword

        //public new void Fun01()  //Apply override using 'new' keyword
        //{
        //    Console.WriteLine("Fun01 from type B");
        //}

        //public void Fun02() // Apply override using 'new' keyword
        //{
        //    Console.WriteLine($"A: {A}, B: {B}");
        //}

        public new void Fun01()
        {
            Console.WriteLine("Fun01 from type B");
        }

        // to override using 'override' keyword Must be the method in the parent class not private and virual
        public override void Fun02()
        {
            Console.WriteLine($"A: {A}, B: {B}");
        }
    }
}
