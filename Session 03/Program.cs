namespace Session_03
{
    // Class
    // Struct
    // Enum
    // Interface
    // Delegate

    public delegate int StringFancDelegate(string s);
    // NEW Delegate => compiler deal with it as a class ==> Pure OOP
    // U can create from delegate a Reference (Pointer) can refre to function or more
    // these function must be have the same signature of the delegate
    // Regardless function name, param name or, access modifiers

    public delegate bool ConditionFuncDelegate(int a);
    internal class Program
    {
        #region PrintArray
        //public static void PrintArray<T>(T[] values)
        //{
        //    Console.WriteLine();
        //    foreach (T item in values)
        //    {
        //        Console.Write($"{item} ");
        //    }
        //    Console.WriteLine();
        //} 
        #endregion

        #region FindOddNumbers
        //public static List<int> FindOddNumbers(List<int> list, ConditionFuncDelegate reference)
        //{
        //    List<int> Result = new List<int>();
        //    if(list?.Count > 0)
        //    {
        //        for(int i =0; i < list.Count; i++)
        //        {
        //            if (reference.Invoke(list[i]))
        //            {
        //                Result.Add(list[i]);
        //            }
        //        }
        //    }
        //    return Result;
        //} 
        #endregion

        #region PrintList
        //public static void PrintList<T>(List<T> values)
        //{
        //    Console.WriteLine();
        //    foreach (T item in values)
        //    {
        //        Console.Write($"{item} ");
        //    }
        //    Console.WriteLine();
        //} 
        #endregion

        static void Main(string[] args)
        {
            #region Delegate Overview
            // Delegate: C# Feature
            // C# Pure OOP

            // Functional Programming
            // Event-Driven Programming 
            #endregion

            #region Delegate EX01
            //StringFancDelegate x;
            //x = StringFunctions.GetCountOfUpperCaseChars;
            //x = StringFunctions.GetCountOfLowerCaseChars;
            ////int count = x.Invoke("Hello World");
            //int count = x("Hello World"); // syntax sugar
            //Console.WriteLine(count); 
            #endregion

            #region Delegate EX02
            //int[] numbers = { 10, 4, 8, 1, 0, 2, 5, 7, 3 };
            //PrintArray(numbers);
            //SortingAlgorithms.BubbleSort(numbers);
            //PrintArray(numbers); 
            #endregion

            #region Delegate EX03

            //List<int> Numbers = Enumerable.Range(1, 100).ToList();
            //List<int> OddNumbers = FindOddNumbers(Numbers, ConditionsFunction.CheckOdd);
            //PrintList(OddNumbers); 
            #endregion

            #region Built-in Delegate
            //// Built-in Delegate
            //// 1. Predicate
            //// 2. Func
            //// 3. Action

            //Predicate<int> predicate = ConditionsFunction.CheckOdd;
            //bool result = predicate.Invoke(5);
            //Console.WriteLine(result); 
            #endregion


        }
    }
}
