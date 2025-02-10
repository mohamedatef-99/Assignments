using System.Collections;
using System.ComponentModel;
using static Session02.ListGenerator;

namespace Session02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // LINQ: 40+ Extension Methods
            // LINQ: 13 Category

            #region Filteration Operators - Where / OfType
            // 1. Filteration Operators - Where / OfType

            // All Product out of stock

            // Fluent Synatx
            //var result = ProductList.Where(P => P.UnitsInStock == 0);

            // Query Syntax
            //var result = from P in ProductList
            //             where P.UnitsInStock == 0
            //             select P;

            // Fluent Synatx
            //var result = ProductList.Where(P => P.Category == "Meat/Poultry");

            // Query Syntax
            //var result = from P in ProductList
            //             where P.Category == "Meat/Poultry"
            //             select P;

            // Fluent Syntax
            //var result = ProductList.Where(P => P.UnitsInStock > 0).Where(P => P.Category == "Meat/Poultry");
            //var result = ProductList.Where(P => P.UnitsInStock > 0 && P.Category == "Meat/Poultry");

            // Query Syntax
            //var result = from P in ProductList
            //             where P.UnitsInStock > 0
            //             where P.Category == "Meat/Poultry"
            //             select P;

            //var result = from P in ProductList
            //             where P.UnitsInStock > 0
            //             && P.Category == "Meat/Poultry"
            //             select P;

            // Indexed Where Valid Only in Fluent Syntax
            // Can't Be Writen using query syntax
            //var result = ProductList.Where((P, Index) => Index < 10 && P.UnitsInStock == 0);
            //var result = ProductList.Where((P, Index) => Index < 5);
            //var result = ProductList.Where(P => P.UnitsInStock > 0).Where((P,I) => I < 5);


            //ArrayList list = new ArrayList() { 1, 2, ProductList[0],4,5.1m,6.2,"fg",1.2f};

            //var result = list.OfType<int>();
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Transformation Operators - Select / SelectMany
            // 2. Transformation Operators - Select / SelectMany

            // Fluent Syntax
            //var result = ProductList.Select(P => P.ProductName);

            // Query Syntax
            //var result = from P in ProductList
            //             select P.ProductName;

            // Fluent Syntax
            //var result = ProductList.Where(P => P.UnitsInStock > 0 && P.Category == "Seafood")
            //    .Select(P => new  { P.ProductName, 
            //        P.Category, 
            //        OldPrice = P.UnitPrice, 
            //        NewPrice = P.UnitPrice - P.UnitPrice * 0.1M 
            //    });

            // Query Syntax
            //var result = from P in ProductList
            //             where P.UnitsInStock > 0 && P.Category == "Seafood"
            //             select new
            //             {
            //                 P.ProductName,
            //                 P.Category,
            //                 OldPrice = P.UnitPrice,
            //                 NewPrice = P.UnitPrice - P.UnitPrice * 0.1M
            //             };

            // Fluent Syntax
            //var result = CustomerList.Select(C => C.CustomerName);
            //var result = CustomerList.Select(C => C.Orders); // If One of the property is sequence
            //var result = CustomerList.SelectMany(C => C.Orders); // If One of the property is sequence

            // Query Syntax
            //var result = from C in CustomerList
            //             from O in C.Orders
            //             select O;

            // Indexed Select Valid Only in Fluent Syntax
            // Can't Be Written using Query Syntax
            // Fluent Syntax
            //var result = ProductList.Select((P, I) => new { I, P.ProductName })
            //    .Where(P => P.I < 5);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion


        }
    }
}
