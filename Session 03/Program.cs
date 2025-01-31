using Session_03.Assignment;

namespace Session_03
{
    #region Delegates
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
    #endregion

    internal delegate string BookDelegate(Book book);
    internal class Program
    {

        #region Demo
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

        #region Function Return
        //public static Action Fun01()
        //{
        //    //Action action = delegate () { Console.WriteLine("Hello Wordl"); }
        //    Action action = () => Console.WriteLine("Hello Wordl");

        //} 
        #endregion
        #endregion

        public static void ProccessBooks(List<Book> books, BookDelegate reference)
        {
            foreach (var book in books)
            {
                Console.WriteLine(reference(book));
            }

        }

        static void Main(string[] args)
        {
            #region Demo
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

            #region Var KeyWord
            // C# keyword
            // var
            //var x = 10;
            //var x = "hell";
            //var predicate = ConditionsFunction 
            #endregion.CheckOdd;

            #endregion

            #region Assignment
            // part 01
            //Book book = new("123", "C#","ahmed", DateTime.Now, 10.00m);
            //Console.WriteLine(book);
            //string bookTitle = BookFunctions.GetTitle(book);
            //string[] bookAuthors = BookFunctions.GetAuthors(book);
            //decimal bookPrice = BookFunctions.GetPrice(book);
            //DateTime bookPublicationDate = BookFunctions.GetPublicationDate(book);
            //string bookISBN = BookFunctions.GetISBN(book);
            //Console.WriteLine($"Book Title: {bookTitle}");
            //Console.WriteLine($"Book Authors: {bookAuthors}");
            //Console.WriteLine($"Book Price: {bookPrice}");
            //Console.WriteLine($"Book Publication Date: {bookPublicationDate}");
            //Console.WriteLine($"Book ISBN: {bookISBN}"); 



            //List<Book> books = new List<Book>
            //{
            //    new Book("123", "C# Programming","ahmed", DateTime.Now, 10.1m),
            //    new Book("1234", "Advanced C#","ahmed", DateTime.Now, 10.0m)
            //};

            //// user defined delegate
            //BookDelegate getISBN = new BookDelegate(BookFunctions.GetISBN);
            //ProccessBooks(books, getISBN);

            //// built-in delegate
            //Func<Book, string> getISBNFunc = BookFunctions.GetISBN;
            //foreach (Book book in books)
            //{
            //    Console.WriteLine(getISBNFunc.Invoke(book));
            //}

            //// anonymous methodd
            //ProccessBooks(books, delegate (Book book) { return book.ISBN; });

            //// lambd expression
            //Func<Book, DateTime> lambdaExpression = book => book.PublicationDate;
            //foreach (var book in books)
            //{
            //    Console.WriteLine(lambdaExpression(book));
            //}
            #endregion

        }
    }

}
