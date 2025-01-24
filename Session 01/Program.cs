namespace Session_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Generics : 

            #region Non Generic SWAP
            //int a = 1;
            //int b = 2;

            //Console.WriteLine($"a: {a}");
            //Console.WriteLine($"b: {b}");
            //Console.WriteLine("After swap");
            //Helper.SWAP(ref a, ref b);
            //Console.WriteLine($"a: {a}");
            //Console.WriteLine($"b: {b}");

            //double a = 1;
            //double b = 2;

            //Console.WriteLine($"a: {a}");
            //Console.WriteLine($"b: {b}");
            //Console.WriteLine("After swap");
            //Helper.SWAP(ref a, ref b);
            //Console.WriteLine($"a: {a}");
            //Console.WriteLine($"b: {b}"); 
            #endregion

            #region Generic SWAP
            //int a = 1;
            //int b = 2;

            //Console.WriteLine($"a: {a}");
            //Console.WriteLine($"b: {b}");
            //Console.WriteLine("After swap");
            //Helper<int>.SWAP(ref a, ref b);
            //Console.WriteLine($"a: {a}");
            //Console.WriteLine($"b: {b}");

            //double x = 1;
            //double y = 2;

            //Console.WriteLine($"a: {x}");
            //Console.WriteLine($"b: {y}");
            //Console.WriteLine("After swap");
            //Helper<double>.SWAP(ref y, ref x);
            //Console.WriteLine($"a: {x}");
            //Console.WriteLine($"b: {y}"); 
            #endregion

            // Linear Search

            #region Linear Search
            //int[] Nums = { 1, 2, 3,64,64,6,58,6,2,4 };

            //int index = Helper.LinearSearch(Nums, 6);
            //Console.WriteLine($"index: {index}");

            //Employee E01 = new Employee() { id = 1, name = "Ahmed", age = 20, salary = 1000};
            //Employee E02 = new Employee() { id = 2, name = "Ahmed", age = 20, salary = 1000};
            //Employee E03 = new Employee() { id = 3, name = "Ahmed", age = 20, salary = 1000};
            //Employee E04 = new Employee() { id = 4, name = "Ahmed", age = 20, salary = 1000};
            //Employee E05 = new Employee() { id = 5, name = "Ahmed", age = 20, salary = 1000};
            //Employee[] employees = {E01, E02, E03, E04, E05};

            //int index = Helper.LinearSearch(employees, E01);
            //Console.WriteLine(index); 
            #endregion

            #region Equality in Class or Struct
            // Equality in Class or Struct
            // Equals in Class: Has Equals Function which inherited from object class ==> compare ref
            // Equals in Struct: Has Equals Function which inherited from object class ==> compare data
            // Note: Struct Dont have Implementaion for the == Opearator

            //Employee E01 = new Employee() { id = 1, name = "Ahmed", age = 20, salary = 1000 };
            //Employee E02 = new Employee() { id = 1, name = "Ahmed", age = 20, salary = 1000 };

            //if (E01.Equals(E02))
            //{
            //    Console.WriteLine("equal");
            //}
            //else
            //{
            //    Console.WriteLine("not equal");
            //} 
            #endregion

            // Sorting: Bubble Sort

            //int[] numbers = { 1, 20, 3, 5,212,2,8,65,14 };

            //Helper.PrintArray(numbers);
            //Console.WriteLine("after");
            //Helper.BubbleSort(numbers);
            //Helper.PrintArray(numbers);

        }
    }
}
