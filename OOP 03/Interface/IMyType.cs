using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_03.Interface
{
    internal interface IMyType
    {
        // What can write inside the interface?
        // 1. Signature of the property
        // 2. Signature of the method  [Name, Parameter, Return Type]
        // 3. Default implementation of the method [Fully Implemented Methods]


        // 2. Signature of the method  [Name, Parameter, Return Type]
        void MyFun();

        // 1. Signature of the property
        double salary { get; set; }

        // 3. Default implementation of the method [Fully Implemented Methods]
        void Print()
        {
            Console.WriteLine("Default implementation of the method [Fully Implemented Methods]");

        }
    }
}
