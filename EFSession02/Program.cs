using EFSession02.Context;
using EFSession02.Entities;
using Microsoft.EntityFrameworkCore;

namespace EFSession02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CRUD Operations

            //AppDbContext context = new AppDbContext();

            //try
            //{
            //    // Code
            //}
            //finally
            //{
            //    AppDbContext context = new AppDbContext();
            //}

            using AppDbContext context = new AppDbContext();

            #region Create - Insert
            // Create - Insert
            //var employee = new Employee()
            //{
            //    Name = "Ahmed",
            //    Age = 25,
            //    Salary = 2555.54
            //};
            //employee.Name = "mohamed";
            //Console.WriteLine(context.Entry(employee).State); // Detached
            //context.Add(employee);
            ////context.Employees.Add(employee);
            //Console.WriteLine(context.Entry(employee).State); // Added
            //var result = context.SaveChanges();
            //Console.WriteLine(context.Entry(employee).State); // Unchange
            //Console.WriteLine(result);

            //context.Add(employee);
            //context.SaveChanges();

            //Console.WriteLine(context.Entry(employee).State);

            //context.Entry(employee).State = EntityState.Added;

            //Console.WriteLine(context.Entry(employee).State);

            //context.SaveChanges(); 
            #endregion

        }
    }
}
