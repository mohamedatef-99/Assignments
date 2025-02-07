using static Session01.ListGenerator;

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

            #region Extension methods
            // Extension methods

            //int num = 101212;

            //var result = IntExtension.Reverse(num);
            //Console.WriteLine(result);
            #endregion

            #region LINQ
            // LINQ: Language Integrated Query
            //     : 40+ Extension methods (LINQ Operators) Against any data [Data in sequence]
            //     : Regardless Data store
            //     : 13 Category
            //     : LINQ Operators Exists in built-in class "Enumerable"


            // Sequence : Object From Class Implement Interface "IEnumerable"
            // local Sequence: L2O (LINQ to Object), L2XML (LINQ to XML)
            // Remote Sequence: L2S (LINQ to SQL), L2EF (LINQ to Entity Framework), L2D (LINQ to Dataset)


            // Input Sequence -> LINQ Operator -> Output Sequence
            // Input Sequence -> LINQ Operator -> One Value
            //                -> LINQ Operator -> Output Sequence

            //List<int> list = new List<int>() { 1,2,3,4,5,6,7,8};

            //var result01 = Enumerable.Where(list, n => n % 2 == 0);
            //var result01 = Enumerable.Any(list, n => n % 2 == 0);
            //var result01 = Enumerable.Range(1,10);
            //foreach (var item in result01)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region LINQ Syntax
            // LINQ Syntax

            // 1. Fluent Syntax
            // Use LINQ Methods
            // 1.1 LINQ Opearator as => Class Memeber method through class "Enumerable"

            //List<int> numbers = new List<int>() { 1,2,3,4,5,6,7,8,9};
            //var reuslt = Enumerable.Where(numbers, x => x % 2 == 0);
            //foreach (var item in reuslt)
            //{
            //    Console.WriteLine($"{item}");
            //}

            // 1.2 LINQ Operator as => Extenision method through sequence

            //List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //var result = numbers.Where(x => x % 2 == 0);
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item}");
            //}

            // 2. Query Syntax [Query Experssion] like SQL style
            // Start from
            // end select, group by

            //List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //var reuslt = from N in numbers
            //             where N % 2 == 0
            //             select N;
            //foreach (var item in reuslt)
            //{
            //    Console.WriteLine($"{item}");
            //}
            /*
             * select n
             * from numbers
             * where n %2==0
             */
            #endregion

            #region LINQ EXecution Ways
            // LINQ EXecution Ways
            // 1. Differed execution way   : 10 Category
            // 2. Immediate execution way  : 3 Category [Elements Operator, Casting Operators, Aggregate Operators]

            //List<int> Numbers = new List<int>() { 1,2,3,4,5,6,7,8,9};
            //var result = Numbers.Where(X => X % 2 == 0); // Differed
            //Numbers.AddRange(new int[]{ 11,22});
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item}");
            //}

            //List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //var result = Numbers.Where(X => X % 2 == 0).ToList(); // Immediate
            //Numbers.AddRange(new int[] { 11, 22 });
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item}");
            //} 
            #endregion

            #region Setup Data
            // Setup Data
            //Console.WriteLine(ProductList[0]);
            //Console.WriteLine(CustomerList[0]);

            //ProductList.Where(P => P.UnitsInStock == 0);
            //var result = CustomerList.Where(P => P.City == "Berlin");
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item}");
            //} 
            #endregion

        }
    }
}
