using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text.RegularExpressions;
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

            #region Aggregate Operators - Immediate Exection
            // Aggregate Operators - Immediate Exection

            // Count - Sum - Max - Min - Avg


            //var result = ProductList.Count(); // LINQ Method
            //var result = ProductList.Count; // Property

            //var result = ProductList.Count(P => P.UnitsInStock == 0);

            //var result = ProductList.Where(P => P.UnitsInStock == 0).Count();

            //var result = ProductList.Sum(P => P.UnitPrice);
            //var result = ProductList.Sum(P => P.UnitsInStock);

            //var result = ProductList.Average(P => P.UnitPrice);

            //var result = ProductList.Max(); // based on ICompareable (Price)
            //var result = ProductList.Max(new ProductCoparerUnitInStock()); // based on IComparer (UnitsInStock)
            //var result = ProductList.Max(P => P.UnitPrice); // max price
            //var result = ProductList.Max(P => P.UnitsInStock); // max units in stock

            //var MaxPrice = ProductList.Max(P => P.UnitPrice); // max price
            //var result = ProductList.FirstOrDefault(P => P.UnitPrice == MaxPrice);

            //var result = ProductList.MaxBy(P => P.UnitPrice);// return Product that has max price


            //var result = ProductList.Min();
            //var result = ProductList.Min(new ProductCoparerUnitInStock());
            //var result = ProductList.Min(P => P.UnitPrice);

            //var result = ProductList.MinBy(P => P.UnitPrice);

            //List<string> names = new List<string>() { "ahmed", "mohamedd" };

            //var result = names.Aggregate((S01,S02) => $"{S01}, {S02}");

            //Console.WriteLine(result); 
            #endregion

            #region Casting Operators - Immediate Execution
            // 6. Casting Operators - Immediate Execution

            //List<Product> list = (List<Product>) ProductList.Where(P => P.UnitsInStock == 0); // Invalid
            //List<Product> list = ProductList.Where(P => P.UnitsInStock == 0).ToList(); // list
            //Product[] list = ProductList.Where(P => P.UnitsInStock == 0).ToArray(); // array
            //Dictionary<long,Product> list = ProductList.Where(P => P.UnitsInStock == 0).ToDictionary(P=> P.ProductID);


            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);   
            //} 
            #endregion

            #region Generation Operators
            // 7. Generation Operators
            // the only way to call this method as => Class memeber method throught "Enumerable" Class

            // Range, Empty, Repeat

            //var result = Enumerable.Range(1, 200);

            //var result = Enumerable.Empty<Product>().ToList();

            //result.Add(new Product() { ProductName = "dsfasf" });

            //var result = Enumerable.Repeat(ProductList[0], 3);
            //var result = Enumerable.Repeat(1, 3);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Set Operators - Union Family
            // 8. Set Operators - Union Family
            // Union - Union All - Intersect, Except

            //var Seq01 = Enumerable.Range(1, 100);
            //var Seq02 = Enumerable.Range(50, 100);

            //var result = Seq01.Union(Seq02); // Like Union in SQL Without Duplication
            //var result = Seq01.Concat(Seq02); // Like Union All in SQL With Duplication
            //result = result.Distinct(); // Remove Duplication

            //var result = Seq01.Intersect(Seq02);
            //var result = Seq01.Except(Seq02);

            //foreach (var item in Seq01)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Quantifiers Operators - Return Boolean
            // 9. Quantifiers Operators - Return Boolean
            // Any - All - SequneceEqual - Contains

            //var Seq01 = Enumerable.Range(1, 100);
            //var Seq02 = Enumerable.Range(50, 100);

            // Any() --> Return True if there are at least one Element [in sequence or match the condition]
            //var result = Seq01.Any(N => N % 2 == 0);

            //var result = ProductList.Any();
            //var result = ProductList.Any(P => P.UnitsInStock == 0);

            // All() --> Return True if all element in the Sequence match the conditions or sequence is Empty
            //var result = ProductList.All(P => P.UnitsInStock == 0);
            //var result = ProductList.All(P => P.UnitPrice > 0);

            //var result = Seq01.SequenceEqual(Seq02);

            //var result = Seq02.Contains(1);
            //var result = Seq02.Contains();

            //Console.WriteLine(result); 
            #endregion

            #region Zipping Operators
            // Zipping Operators
            // zip

            //List<string> words = new List<string>() { "ten", "twenty", "thirty"};
            //List<int> numbers = new List<int>() { 10,2,20,24,62};

            //var result = words.Zip(numbers, (w,n) => $"{n} --> {w}");

            //foreach (var item in words)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Grouping Operators
            // Grouping Operators

            //var result = ProductList.GroupBy(P => P.Category);

            //result = from P in ProductList
            //         where P.UnitsInStock > 0
            //         group P by P.Category
            //         into Category
            //         where Category.Count() > 10
            //         select new { CategoryName = Category.Key, CountOfCategory = Category.Count() };

            //var result = ProductList.Where(P => P.UnitsInStock > 0)
            //    .GroupBy(P => P.Category)
            //    .Where(C => C.Count() > 5)
            //    .Select(c => new { CategoryName = c.Key, CountOfCategory = c.Count() });

            //foreach (var item in result)
            //{
            //    //Console.WriteLine(Category.Key);
            //    //foreach (var product in Category)
            //    //{
            //    //    Console.WriteLine(product);
            //    //}
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Partioning Operators - Take, TakeLast, Skip, SkipLast, TakeWhile, SkipWhile
            // Partioning Operators - Take, TakeLast, Skip, SkipLast, TakeWhile, SkipWhile

            // used for pagination

            //var restult = ProductList.Where(P => P.UnitsInStock == 0).Take(2);
            //var restult = ProductList.Where(P => P.UnitsInStock == 0).TakeLast(2);
            //var restult = ProductList.TakeLast(2);


            //var restult = ProductList.Skip(0).Take(5);
            //var restult = ProductList.Skip(5).Take(5);
            //var restult = ProductList.SkipLast(5);

            //int[] Numbers = { 1, 2, 3, 5, 89, 6, 5 };

            //var result = Numbers.TakeWhile((N) => N % 3 == 0);
            //var result = Numbers.SkipWhile((N) => N % 3 == 0);


            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region let  / into 
            // let  / into 

            // Query Syntax

            //List<string> Names = new List<string>() { "ahmed", "mohamed"};

            //var result = from Name in Names
            //             select Regex.Replace(Name, "[aeoiuAEOIU]", string.Empty)
            //             into NoVolName
            //             // into: Restart Query with introducing New Range variable
            //             where NoVolName.Length > 3
            //             select NoVolName;


            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion
        }
    }
}
