using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_03.Interface
{
    internal class MyType : IMyType /* : => Implement*/
    {
        public double salary
        {
            get;
            set;
        }

        public void MyFun()
        {
            Console.WriteLine("Hello");
        }
    }
}
