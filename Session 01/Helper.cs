using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_01
{
    internal static class Helper<T01> where T01 : class, /*// struct // Point // notnull*/ IComparable, ICloneable, IComparer, new()
    {
        // Generic Constraints:
        // 1. Primary Constraints
                // the type is class or struct or special type like point or enum or notnull
        // 2. Secondary
        //      // T implement specifice interface
        // 3. Constructor Constraints
        //    new()


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

        public static void BubbleSort<T>(T[] Arr) where T : IComparable
        {
            if (Arr?.Length > 0)
            {
                for(int i =0; i< Arr.Length; i++)
                {
                    for(int j = 0; j < Arr.Length - i -1 ; j++)
                    {
                        if (Arr[j].CompareTo(Arr[j+1]) > 0)
                        {
                            SWAP(ref Arr[i], ref Arr[j +1]);
                        }
                    }
                }
            }
        }

        public static void PrintArray<T>(T[] arr)
        {
            foreach (T i in arr)
            {
                Console.Write(i);
            }
        }
    }
}
