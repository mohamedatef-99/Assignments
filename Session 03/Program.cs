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

    internal class Program
    {
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


        }
    }
}
