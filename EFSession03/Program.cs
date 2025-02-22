using EFSession03.Context;
using EFSession03.Models;

namespace EFSession03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 3 Ways to generate schema
            // 1. TPC  : Table Per Class
            // 2. TPH  : Table Per Hierarchy
            // 3. TPCC : Table Per Concert Class


            using AppDbContext context = new AppDbContext();

            //FullTimeEmployee fullTimeEmployee01 = new FullTimeEmployee()
            //{
            //    Name = "Ahmed Ali",
            //    Email = "ahmed@gmail.com",
            //    Salary = 1000
            //};

            //FullTimeEmployee fullTimeEmployee02 = new FullTimeEmployee()
            //{
            //    Name = "Ahmed Kalid",
            //    Email = "khalid@gmail.com",
            //    Salary = 2000
            //};

            //FullTimeEmployee fullTimeEmployee03 = new FullTimeEmployee()
            //{
            //    Name = "Mariam",
            //    Email = "Mariam@gmail.com",
            //    Salary = 3000
            //};

            //PartTimeEmployee partTimeEmployee01 = new PartTimeEmployee()
            //{
            //    Name = "Mohamed Ahmed",
            //    Email = "mohamed@gmail.com",
            //    HoureRate = 10,
            //    NumberOfHoure = 10
            //};

            //PartTimeEmployee partTimeEmployee02 = new PartTimeEmployee()
            //{
            //    Name = "osama mohamed",
            //    Email = "osama@gmail.com",
            //    HoureRate = 5,
            //    NumberOfHoure = 9
            //};

            //PartTimeEmployee partTimeEmployee03 = new PartTimeEmployee()
            //{
            //    Name = "sayed mahmoud",
            //    Email = "sayed@gmail.com",
            //    HoureRate = 15,
            //    NumberOfHoure = 20
            //};

            //context.FullTimeEmployees.Add(fullTimeEmployee01);
            //context.FullTimeEmployees.Add(fullTimeEmployee02);
            //context.FullTimeEmployees.Add(fullTimeEmployee03);

            //context.PartTimeEmployees.Add(partTimeEmployee01);
            //context.PartTimeEmployees.Add(partTimeEmployee02);
            //context.PartTimeEmployees.Add(partTimeEmployee03);

            //context.SaveChanges();

            //foreach (var item in context.PartTimeEmployees)
            //{
            //    Console.WriteLine(item.Name);
            //}

            //foreach (var item in context.FullTimeEmployees)
            //{
            //    Console.WriteLine(item.Name);
            //}

            //foreach (var item in context.Employees)
            //{
            //    Console.WriteLine(item.Name);
            //}

            //var result = context.Employees.OfType<FullTimeEmployee>();
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.Name);
            //}

            //var result = context.FullTimeEmployees.FirstOrDefault(E => E.Id == 1);
            //Console.WriteLine(result.Name);



        }
    }
}
