using System;
using System.Collections;
using System.Collections.Generic;
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

            #region Ordering Operators 
            // 3. Ordering Operators 

            // Sorting

            //var result = ProductList.OrderBy(P => P.UnitPrice);
            //var result = ProductList.OrderBy(P => P.UnitsInStock)
            //    .Select(P => 
            //    new {P.ProductName, P.UnitPrice, P.UnitsInStock });

            //var result = ProductList.OrderByDescending(P => P.UnitsInStock)
            //    .Select(P =>
            //    new { P.ProductName, P.UnitPrice, P.UnitsInStock });

            //var result = ProductList.OrderByDescending(P => P.UnitsInStock)
            //    .ThenBy(P => P.UnitPrice)
            //   .Select(P =>
            //   new { P.ProductName, P.UnitPrice, P.UnitsInStock });

            //var result = ProductList.OrderByDescending(P => P.UnitsInStock)
            //    .ThenByDescending(P => P.UnitPrice)
            //   .Select(P =>
            //   new { P.ProductName, P.UnitPrice, P.UnitsInStock });

            //var result = ProductList.Where(P=> P.Category == "Seafood").OrderByDescending(P => P.UnitsInStock)
            //   .ThenByDescending(P => P.UnitPrice)
            //  .Select(P =>
            //  new { P.ProductName, P.UnitPrice, P.UnitsInStock });


            // Query Syntax
            //var result = from P in ProductList
            //             orderby P.UnitPrice descending
            //             select P;

            //var result = from P in ProductList
            //             orderby P.UnitPrice, P.UnitsInStock descending
            //             select P;


            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Elements Operators - Immediate Execution
            // 4. Elements Operators - Immediate Execution

            //var result = ProductList.First(); // First => may throw Execption if the list doesnt contain elements
            //var result = ProductList.Last(); // Last => may throw Execption if the list doesnt contain elements

            //var result = ProductList.First(P => P.UnitsInStock == 1000); // First => may throw Execption if the list doesnt contain elements
            //var result = ProductList.First(P => P.UnitsInStock == 0); // Last => may throw Execption if the list doesnt contain elements

            //var result = ProductList.FirstOrDefault(new Product() { ProductName = "dfdsf"}); // will not throw execption if list is empty. it will return null

            //var result = ProductList.FirstOrDefault(P => P.UnitsInStock == 1000 /*it will return null so it takes anothor arg to return if null*/, new Product() { ProductName = "dfdsf" });

            //var result = ProductList.LastOrDefault(); // return null if empty
            //var result = ProductList.LastOrDefault(new Product() { ProductName = "dfdsf" }); // takes default value to return if null
            //var result = ProductList.LastOrDefault(P => P.UnitsInStock == 1000); // return null if empty
            //var result = ProductList.LastOrDefault(P => P.UnitsInStock == 1000, new Product() { ProductName = "dfdsf" }); // takes default value to return if null

            // Note: All sequence is array based
            //var result = ProductList.ElementAt(0); // return first index
            //var result = ProductList.ElementAt(100000000000000000000000000000000000000); // throw exception if index out of the range

            //var result = ProductList.ElementAtOrDefault(1); // if sequence empty it will return null

            //var result = ProductList.Single(); // throw exception if sequence contain more than one element or sequence contain no element
            //var result = ProductList.Single(P => P.UnitsInStock == 0); // throw exception if sequence contain more than one element or sequence contain no element

            //var result = ProductList.SingleOrDefault(P => P.UnitsInStock == 1000); // throw exception if sequence contain more than one element and if sequence contain no element it will return default value [null]

            //var result = ProductList.SingleOrDefault(P => P.UnitsInStock == 1000, new Product() { ProductName = "default value" }); // takes default value to return if returns null

            //var result = ProductList.DefaultIfEmpty(new Product() { ProductName="dfsdf"}); // [check if sequence is empty] return empty sequence or default value if sequence empty
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine(result?.ProductName ?? "NA"); 
            #endregion



        }
    }
}
