﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_03
{
    internal interface IShape
    {
        public double Area { get; set; }

        void DisplayShapeInfo();
    }
}
