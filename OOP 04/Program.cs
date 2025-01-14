using OOP_04.Abstracts;
using OOP_04.Mapping;
using OOP_04.Operator_overloading;
using OOP_04.Static;

namespace OOP_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Abstraction
            //// 4. Abstraction: 
            //// abstract : C# keyword [class - methods - properties]
            //// abastract class
            //// abstract method
            //// absract property

            //// 2D Shape

            ////Shape shape = new Shape();
            //// Note: Cant create object from abstract class

            //Rectangle rectangle = new Rectangle() { Dim01 = 10, Dim02 = 10, };

            //Console.WriteLine(rectangle.Perimeter);
            //Console.WriteLine(rectangle.GetArea());

            //rectangle.print(); 
            #endregion

            #region Interface Vs Abstract Class
            //Interface Vs Abstract Class 
            #endregion

            #region Operator Overloading
            // Operator Overloading

            // *-/+||&&>>

            // Complex Number : 

            //Complex c01 = new Complex() { Real = 3, Imag = 4 };
            //Complex c02 = new Complex() { Real = 3, Imag = 4 };

            //Console.WriteLine(c01);
            //Console.WriteLine(c02);

            //Complex C03 = c01 + c02;
            //Console.WriteLine(C03);

            //// ++ --
            //int x = 12;
            //x++;
            //Console.WriteLine(x);

            //c01++;
            //Console.WriteLine(c01);

            //c01--;
            //Console.WriteLine(c01); 
            #endregion

            #region User Defined Casting
            //double x = 12;
            //int y = (int)x;

            //Complex C01 = new Complex() { Real = 3, Imag = 4 };

            //string s = (string)C01;
            //// (string) : Convert complex number to string

            //// Operator Overloading
            //// User-Defined Casting Operator

            //Console.WriteLine(s);

            //int z = (int)C01;
            //Console.WriteLine(z);

            //// Mapping : Convert From DataType to DataType


            //// Code Firt
            //// DB Firt

            //User user = new User();

            //// Mannual Mapping
            //UserDto userDto = new UserDto()
            //{
            //    Email = user.Email,
            //    Name = user.Name,

            //};

            //// Casting Operator

            //// Automapper : Mapping Automatic 
            #endregion

            #region Static
            // Static : C# keyword [class - method - property - constructor - attributes]
            // static class
            // static method
            // static property
            // static consturctor
            // static attributes

            //Utilities U01 = new Utilities();
            //Utilities U02 = new Utilities();
            //Utilities U03 = new Utilities();
            //Console.WriteLine(Utilities.CmToInch(254));
            //Console.WriteLine(Utilities.CmToInch(254));
            //Console.WriteLine(Utilities.CmToInch(254)); 
            #endregion

            // Sealed : C# keyword [class - method - property]  Cant override or inheret

        }
    }
}
