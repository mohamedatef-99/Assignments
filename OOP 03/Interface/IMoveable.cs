using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_03.Interface
{
    internal interface IMoveable
    {
        public int Speed { get; set; }
        void Forward();
        public void Backward();

        void Left();
        void Right();
    }
}
