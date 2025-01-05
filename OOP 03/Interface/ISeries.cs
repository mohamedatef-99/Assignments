using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_03.Interface
{
    internal interface ISeries
    {
        int Current { get; set; } // Signature of the property

        void Next(); // Signature of the method

        void Reset(); // Signature of the method
    }
}
