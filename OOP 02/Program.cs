using OOP_02.Inheritance;

namespace OOP_02
{
    internal class Program
    {
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


        }
    }
}
