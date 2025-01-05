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
        }
    }
}
