using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_04.Static
{
    internal class Utilities
    {
        public int x { get; set; }
        public int y { get; set; }

        // Static Method : Class member Method
        public static double CmToInch(double cm)
        {
            return cm / 2.54;
        }
    }
}
