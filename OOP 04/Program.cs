using OOP_04.Abstracts;
using OOP_04.Assignment;
using OOP_04.Mapping;
using OOP_04.Operator_overloading;
using OOP_04.Static;

namespace OOP_04
{
    internal class Program
    {
        public static Point3D ReadInput(string pointName)
        {
            int x, y, z;
            bool flag;

            Console.WriteLine($"\nEnter coordinates for {pointName}:");

            do
            {
                Console.Write("Enter X coordinate: ");
                flag = int.TryParse(Console.ReadLine(), out x);
            } while (!flag);

            do
            {
                Console.Write("Enter Y coordinate: ");
                flag = int.TryParse(Console.ReadLine(), out y);
            } while (!flag);

            do
            {
                Console.Write("Enter Z coordinate: ");
                flag = int.TryParse(Console.ReadLine(), out z);
            } while (!flag);

            return new Point3D(x, y, z);
        }
        static void Main(string[] args)
        {
            #region Demo
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
            #endregion

            #region Dev
            #region Firt Project
            //// First Project
            //Point3D p1 = ReadInput("P1");
            //Console.WriteLine(p1);

            //Point3D p2 = ReadInput("P2");
            //Console.WriteLine(p2);

            //if (p1 == p2)
            //{
            //    Console.WriteLine("points are equal");
            //}
            //else
            //{
            //    Console.WriteLine("points are not equal");
            //}

            //Point3D[] points =
            //{
            //    new Point3D(1,3,3),
            //    new Point3D(1,0,1),
            //    new Point3D(1,0,2),
            //};
            //Array.Sort(points);
            //Console.WriteLine("sorted points: ");
            //foreach (var point in points)
            //{
            //    Console.WriteLine(point);
            //}

            //Point3D clone = (Point3D)p1.Clone();
            //Console.WriteLine("clone: " + clone); 
            #endregion

            #region Second Project
            // Second Project
            //int x, y;
            //bool flag;

            //do
            //{
            //    Console.Write("X: ");
            //    flag = int.TryParse(Console.ReadLine(), out x);
            //} while (!flag);

            //do
            //{
            //    Console.Write("Y: ");
            //    flag = int.TryParse(Console.ReadLine(), out y);
            //} while (!flag);

            //int add = Maths.Add(x, y);
            //int sub = Maths.Subtract(x, y);
            //int divide = Maths.Divide(x, y);
            //int multiply = Maths.Multiply(x, y);

            //Console.WriteLine($"sum: {add}");
            //Console.WriteLine($"sub: {sub}");
            //Console.WriteLine($"divide: {divide}");
            //Console.WriteLine($"multiply: {multiply}");

            #endregion

            #region Third Project
            //Duration D1 = new Duration(1, 10, 15);
            //Console.WriteLine(D1.ToString());

            //Duration D2 = new Duration(7800);
            //Console.WriteLine(D2.ToString());

            //Duration D3 = new Duration(666);
            //Console.WriteLine(D3.ToString());

            //Duration D4 = new Duration(6);
            //Console.WriteLine(D4.ToString());

            //D3 = D1 + D2;
            //Console.WriteLine(D3.ToString()); 

            //D3 = D1 + 7800;
            //Console.WriteLine(D3.ToString()); 

            //D3 = 666 + D3;
            //Console.WriteLine(D3.ToString()); 

            //D3 = ++D1;
            //Console.WriteLine(D3.ToString()); 

            //D3 = --D2;
            //Console.WriteLine(D3.ToString()); 

            //D1 = D1 - D2;
            //Console.WriteLine(D1.ToString());

            //if (D1 > D2)
            //{
            //   Console.WriteLine("D1 is greater than D2");
            //}
            //else
            //{
            //   Console.WriteLine("D1 is not greater than D2");
            //}

            //if (D1 <= D2)
            //    Console.WriteLine("D1 is less than or equal D2");

            //if (D1)
            //    Console.WriteLine($"D1: {D1}");

            //DateTime dateTime = (DateTime)D1;
            //Console.WriteLine($"DateTime: {dateTime:HH:mm:ss}"); 
            #endregion 
            #endregion


        }
    }
}
