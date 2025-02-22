using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using EFSession03Demo.Entitis;
using Microsoft.EntityFrameworkCore;

namespace EFSession03Demo
{
    class AppDbContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseLazyLoadingProxies(); // OR
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer("Server = .; Database = EFSession03; Trusted_Connection = True; TrustServerCertificate = True");

            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}
