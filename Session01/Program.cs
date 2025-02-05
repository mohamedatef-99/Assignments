namespace Session01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Implicity type local variable [var - dynamic]
            // Implicity type local variable [var - dynamic]

            // var
            //var data01 = "Ahmed";
            // Compiler can detect the datatype of the local variable based on the initial value
            // the local variable must be initialized
            // var data02; // Error
            // can't initialize the local variable with null
            // var data03 = null; // Error
            // can't change the datatype of the local variable
            // data01 = 10; // Error
            // can't use var as parameter or return type

            // dynamic
            //dynamic data04 = "Ahmed";
            //data04 = 10;
            //data04 = 10.1;
            //data04 = 10.1m;
            //data04 = 10.1f;
            //data04 = true;

            // CLR Detect the datatype of the local variable on last value at run time
            // don't need to be initialized
            // can initialize the local variable with null
            // can change the datatype of the local variable
            // be careful when using dynamic
            // it like var in JS 
            #endregion

            #region Anonymous type
            // Anonymous type
            // Employee E01 = new Employee { Id = 1, Name = "Ahmed", Salary = 1000 };
            //var E01 = new { Id = 1, Name = "Ahmed", Salary = 1000 };
            //Console.WriteLine(E01.Id);

            //E01.Id = 2; // Invalid : Immutable cant change its value after creation

            //Console.WriteLine(E01.GetType().Name);

            // The same anonymous type as long as:
            // 1. The properties are the same
            // 2. The properties are in the same order
            // 3. The properties have the same data type 
            #endregion



        }
    }
}
