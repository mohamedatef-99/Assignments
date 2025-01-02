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
        }
    }
}
