using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_01
{
    internal static class Helper
    {
       public static void SWAP<T>(ref T x, ref T y)
        {
            T Temp = x;
            x = y;
            y = Temp;
        }

        //public static int LinearSearch(int[] Arr, int value)
        //{
        //    if (Arr?.Length > 0)
        //    {
        //        for (int i = 0; i < Arr.Length; i++)
        //        {
        //            if (Arr[i] == value) return i;
        //        }
        //    }
        //    return -1;
        //}

        public static int LinearSearch<T>(T[] Arr, T value)
        {
            if (Arr?.Length > 0)
            {
                for (int i = 0; i < Arr.Length; i++)
                {
                    if (Arr[i].Equals(value)) return i;
                }
            }
            return -1;
        }
    }
}
