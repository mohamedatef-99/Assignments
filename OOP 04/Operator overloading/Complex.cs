using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_04.Operator_overloading
{
    internal class Complex
    {
        public int Real { get; set; }

        public int Imag { get; set; }

        // Operator Overloading
        // +
        // Must be : Public - static
        public static Complex operator +(Complex left, Complex right)
        {
            return new Complex()
            {
                Real = left?.Real ?? 0+ right.Real,
                Imag = left?.Imag ?? 0 + right.Imag
            };
        }


        public static Complex operator -(Complex left, Complex right)
        {
            return new Complex()
            {
                Real = left.Real - right.Real,
                Imag = left.Imag - right.Imag
            };
        }

        // Operator Overloading
        // ++ --
        // Must be : Public - static
        public static Complex operator ++(Complex complex)
        {
            complex.Real++;
            return complex;
        }

        public static Complex operator --(Complex complex)
        {
            complex.Real--;
            return complex;
        }

        public override string ToString()
        {
            return $"{Real} + {Imag} i";
        }
    }
}
