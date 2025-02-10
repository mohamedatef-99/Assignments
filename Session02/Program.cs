using System.Collections;
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



        }
    }
}
