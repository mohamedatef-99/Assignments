using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session01
{
    internal static class IntExtension
    {
        public static int Reverse(this int number)
        {
            int ReversedNumber = 0;
            while (number > 0)
            {
                ReversedNumber = ReversedNumber * 10 + number % 10;
                number = number / 10;
            }
            return ReversedNumber;
        }
    }
}
