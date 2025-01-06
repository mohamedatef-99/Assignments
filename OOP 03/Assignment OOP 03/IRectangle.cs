using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_03
{
    internal interface IRectangle: IShape
    {
        public double Lenght { get; set; }
        public double Width { get; set; }
    }
}
