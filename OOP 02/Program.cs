using OOP_02.Inheritance;
using OOP_02.Override;

namespace OOP_02
{
    internal class Program
    {

        //static int sum(int x, int y)
        //{
        //    return x + y;
        //}

        //static double sum(double x, double y)
        //{
        //    return x + y;
        //}
        static void Main(string[] args)
        {
            #region Class VS Struct
            // Class Vs Struct
            // Class is a reference type, Struct is a value type
            // Class object is stored in heap, Struct object is stored in stack
            // Class support OOP Principles, Struct does not support OOP Principles Only Encapsulation
            // Class when use new keyword it create object, Struct use new keyword to choose constructor
            // Class can have constructor and its default do nothing, Struct can have constructor and init the attributes with its default value
            // Class when init user defined constructor it cancel the CLR, Struct when init user defined constructor it does not cancel the CLR(if prameterless it cancel the default )
            // Class life time is longer than Struct
            // Class support all access modifiers, Struct support only public and internal and private


            // When to use Class and when to use Struct
            // Use Class when you need to create a large object that will be used in many places in the program
            // if want to use OOP Principles use class
            // Use Struct when you need to create a small object that will be used in a few places in the program

            #endregion

            #region Inheritance
            // 2. Inheritance
            // Inheritance is a mechanism in which one object acquires all the properties and behaviors of a parent object.
            // X ===> Y

            //Parent parent = new Parent(1,2);

            //Console.WriteLine(parent);

            //parent.Fun01();
            //parent.Fun02();

            //Child child = new Child(1, 2, 2);
            //child.Fun01();
            //child.Fun02(); 
            #endregion

            #region Polymorphism
            // 3. Polymorphism
            // 3.1 Polymorphism Method (Function) Overloading
            // 3.2 Polymorphism Method (Function) Overriding


            // 3.1 Polymorphism Method (Function) Overloading
            // There are more than one method or function (in the same scope [class - struct]) have the same NAME but with different signature(count - type - order) of parameters
            // OR
            // Polymorphism Method (Function) Overloading is a mechanism that allows you to define the same method more than once in the same class
            // but with different parameters.
            // The parameters can differ in the number of parameters or the data type of the parameters.

            //sum(1, 2);
            //sum(1.3,2.20);


            // 3.2 Polymorphism Method (Function) Overriding
            // There are more than on fucntions [in different class] these have the same name and the same signaure but with different behaviour

            //TypeB typeB = new TypeB() { A = 1, B = 2};

            //typeB.A = 1;
            //typeB.B = 2;

            //typeB.Fun01();
            //typeB.Fun02(); 
            #endregion


        }
    }
}
