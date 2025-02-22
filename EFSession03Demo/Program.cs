using EFSession03Demo.Entitis;
using Microsoft.EntityFrameworkCore;

namespace EFSession03Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using AppDbContext context = new AppDbContext();


            //var department = new List<Department>()
            //{
            //    new Department() {Name = "HR"},
            //    new Department() {Name = "PR"},
            //    new Department() {Name = "IT"},
            //};

            //var employees = new List<Employee>()
            //{
            //    new Employee() {Name = "Ahmed Ali", Address = "Cairo", Age = 20, Salary = 1000, DeptId = 100},
            //    new Employee() {Name = "mahmoud ahmed", Address = "alex", Age = 30, Salary = 2000, DeptId = 100},
            //    new Employee() {Name = "tamer ahmed", Address = "Cairo", Age = 28, Salary = 3000, DeptId = 300},
            //    new Employee() {Name = "mohmed atef", Address = "alex", Age = 21, Salary = 4000, DeptId = 100},
            //    new Employee() {Name = "naser mohamed", Address = "Cairo", Age = 30, Salary = 5000, DeptId = 200},
            //    new Employee() {Name = "sayed mahmoud", Address = "Cairo", Age = 22, Salary = 6000, DeptId = 100},
            //    new Employee() {Name = "mariam ahmed", Address = "Cairo", Age = 40, Salary = 7000, DeptId = 300}
            //};

            //context.Departments.AddRange(department);
            //context.Employees.AddRange(employees);

            //context.SaveChanges();

            //var employee = context.Employees.FirstOrDefault(E => E.Id == 10);
            // Console.WriteLine(employee?.Id ?? 0);
            // Console.WriteLine(employee?.Name ?? "NA");
            // Console.WriteLine(employee?.Salary ?? 0);
            // Console.WriteLine(employee?.Age ?? 0);
            // Console.WriteLine(employee?.Address ?? "NA");
            // Console.WriteLine(employee?.WorkFor?.Name ?? "NA");


            //var department = context.Departments.FirstOrDefault(D => D.Id == 100);
            //Console.WriteLine(department.Name);
            //foreach (var item in department.Employees)
            //{
            //    Console.WriteLine(item.Name);
            //}
            // NOTE: EF Core Dont Loading Any Navigational Property

            // EF Core Loading Navigtional Property
            // 1. Explicit Loading
            // 1. Eager Loading
            // 3. Lazing Loading

            #region Explicit Loading
            // 1. Explicit Loading
            //var employee = context.Employees.FirstOrDefault(E => E.Id == 10);

            // loading the workFor property 
            //context.Entry(employee).Reference("WorkFor").Load(); // Explict Loading for navigtional Property
            //context.Entry(employee).Reference(nameof(Employee.WorkFor)).Load(); // Explict Loading for navigtional Property
            //context.Entry(employee).Reference(E => E.WorkFor).Load(); // Explict Loading for navigtional Property

            //Console.WriteLine(employee?.Id ?? 0);
            //Console.WriteLine(employee?.Name ?? "NA");
            //Console.WriteLine(employee?.Salary ?? 0);
            //Console.WriteLine(employee?.Age ?? 0);
            //Console.WriteLine(employee?.Address ?? "NA");
            //Console.WriteLine(employee?.WorkFor?.Name ?? "NA");


            //var department = context.Departments.FirstOrDefault(D => D.Id == 100);

            //context.Entry(department).Collection(D => D.Employees).Load(); // Explict Loading


            //Console.WriteLine(department.Name);
            //foreach (var item in department.Employees)
            //{
            //    Console.WriteLine(item.Name);
            //} 
            #endregion

            #region Eager Loading
            // 2. Eager Loading
            //var employee = context.Employees.Include(E => E.WorkFor).FirstOrDefault(E => E.Id == 10);

            //Console.WriteLine(employee?.Id ?? 0);
            //Console.WriteLine(employee?.Name ?? "NA");
            //Console.WriteLine(employee?.Salary ?? 0);
            //Console.WriteLine(employee?.Age ?? 0);
            //Console.WriteLine(employee?.Address ?? "NA");
            //Console.WriteLine(employee?.WorkFor?.Name ?? "NA");


            //var department = context.Departments.Include(D => D.Employees).FirstOrDefault(D => D.Id == 100);
            //Console.WriteLine(department.Name);
            //foreach (var item in department.Employees)
            //{
            //    Console.WriteLine(item.Name);
            //} 
            #endregion

            #region Lazing Loading
            // 3. Lazing Loading
            // 3.1. Install Package Proxies
            // 3.2. Update OnConfiguring(), Use UseLazyLoadingProxies
            // 3.3. Make All Entitis Public
            // 3.4. Make All Navigational Propertes Virtual 


            //var employee = context.Employees.FirstOrDefault(E => E.Id == 10);
            //Console.WriteLine(employee?.Id ?? 0);
            //Console.WriteLine(employee?.Name ?? "NA");
            //Console.WriteLine(employee?.Salary ?? 0);
            //Console.WriteLine(employee?.Age ?? 0);
            //Console.WriteLine(employee?.Address ?? "NA");
            //Console.WriteLine(employee?.WorkFor?.Name ?? "NA");


            //var department = context.Departments.FirstOrDefault(D => D.Id == 100);
            //Console.WriteLine(department.Name);
            //foreach (var item in department.Employees)
            //{
            //    Console.WriteLine(item.Name);
            //} 
            #endregion

        }
    }
}
