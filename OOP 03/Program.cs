using OOP_03.Assignment_OOP_03;
using OOP_03.Interface;

namespace OOP_03
{
    internal class Program
    {
        //static void PrintNum(SeriesByTwo series)
        //{
        //    for(int i = 0; i< 10; i++)
        //    {
        //        Console.Write($"{series.Current} ");
        //        series.Next();
        //    }
        //    Console.WriteLine();
        //    series.Reset();
        //}

        //static void PrintNum(ISeries series)  // instead of repeating the same code, we can use interface and it will accept any class which is implement the interface
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.Write($"{series.Current} ");
        //        series.Next();
        //    }
        //    Console.WriteLine();
        //    series.Reset();
        //}
        static void Main(string[] args)
        {
            #region Interface
            // Interface : Reference type
            // Code Contract


            // IMyType myType = new IMyType(); // Error
            // NOte: cant create object of interface

            //MyType myType = new MyType();
            //myType.salary = 1000;
            //Console.WriteLine(myType.salary);
            //myType.MyFun();

            //IMyType myType;
            //// Ref --> Can Refer to the object of the class which implements the interface 'IMyType'
            //myType = new MyType();
            //myType.salary = 1000;
            //Console.WriteLine(myType.salary);
            //myType.MyFun();
            //myType.Print(); 
            #endregion

            #region Interface Example
            //SeriesByTwo series = new SeriesByTwo();
            //PrintNum(series);

            //Car car = new Car();
            //car.Speed = 100;

            //car.Forward();

            //Airline airline = new Airline();

            //IMoveable moveable = airline;
            //moveable.Forward();


            //IFlyable flyable = airline;
            //flyable.Forward(); 
            #endregion

            #region Shallow Copy VS Deep Copy
            // Shallow Copy VS Deep Copy

            //Shallow Copy

            //int[] arr1 = { 1, 2, 3, 4, 5 };
            //int[] arr2 = { 6, 7, 8, 9, 10 };

            //Console.WriteLine($"Arr01: {arr1.GetHashCode()}");
            //Console.WriteLine($"Arr02: {arr2.GetHashCode()}");

            //arr2 = arr1; // Shallow Copy
            ////{ 1, 2, 3, 4, 5 } --> Has Two Reference arr1, arr2
            ////{ 6, 7, 8, 9, 10 } --> Unerechable code

            //Console.WriteLine($"Arr01: {arr1.GetHashCode()}");
            //Console.WriteLine($"Arr02: {arr2.GetHashCode()}");

            //// Identity (Address) + Object State (Data)


            //// Deep Copy

            //arr2 = (int[]) arr1.Clone(); // Deep Copy
            //                             // Clone Method will copy the object state of the caller
            //                             // assign the new object to the arr2, will generate new identity

            //Console.WriteLine($"Arr01: {arr1.GetHashCode()}");
            //Console.WriteLine($"Arr02: {arr2.GetHashCode()}");


            //string[] arr1 = {"Ahmed", "Mohamed" };
            //string[] arr2 = { "Ali", "mahmoud" };

            //Console.WriteLine($"Arr01: {arr1.GetHashCode()}");
            //Console.WriteLine($"Arr02: {arr2.GetHashCode()}");

            //arr2 = arr1;

            //Console.WriteLine($"Arr01: {arr1.GetHashCode()}");
            //Console.WriteLine($"Arr02: {arr2.GetHashCode()}");

            //arr2[0] = "Hassan";
            //Console.WriteLine(arr2[0]);


            //string[] arr1 = { "Ahmed", "Mohamed" };
            //string[] arr2 = { "Ali", "mahmoud" };

            //Console.WriteLine($"Arr01: {arr1.GetHashCode()}");
            //Console.WriteLine($"Arr02: {arr2.GetHashCode()}");

            //arr2 = (string[]) arr1.Clone();

            //Console.WriteLine($"Arr01: {arr1.GetHashCode()}");
            //Console.WriteLine($"Arr02: {arr2.GetHashCode()}");

            //arr2[0] = "Hassan";
            //Console.WriteLine(arr2[0]); 
            #endregion

            // Assignment
            #region Part 1
            // Part 1

            /*
            Question 1:
            What is the primary purpose of an interface in C#?
            Answer: b) To define a blueprint for a class 
            */

            /*
             Question 2:
             Which of the following is NOT a valid access modifier for interface members in C#?
             Answer: a) private
             */

            /*
             Question 3:
             Can an interface contain fields in C#?
             Answer: b) No
             */
            /*
             Question 4:
             In C#, can an interface inherit from another interface?
             Answer: b) Yes, interfaces can inherit from multiple interfaces
             */

            /*
             Question 5:
             Which keyword is used to implement an interface in a class in C#?
             Answer: d) implements
            */

            /*
             Question 6:
             Can an interface contain static methods in C#?
             Answer: a) Yes
            */

            /*
             Question 7:
             In C#, can an interface have explicit access modifiers for its members?
             Answer: b) No, all members are implicitly public
            */

            /*
            Question 8:
            What is the purpose of an explicit interface implementation in C#?
            Answer: b) To provide a clear separation between interface and class members
           */

            /*
            Question 9:
            In C#, can an interface have a constructor?
            Answer: b) No, interfaces cannot have constructors
           */

            /*
            Question 10:
            How can a C# class implement multiple interfaces?
            Answer: c) By separating interface names with commas
           */
            #endregion

            // Part 2
            #region Question 01
            // Question 01

            Circle circle = new Circle(5);
            circle.DisplayShapeInfo();

            Rectangle rectangle = new Rectangle(4, 6);
            rectangle.DisplayShapeInfo(); 
            #endregion


        }
    }
}
