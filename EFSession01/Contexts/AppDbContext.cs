using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFSession01.Entities;
using Microsoft.EntityFrameworkCore;

namespace EFSession01.Contexts
{
    class AppDbContext : DbContext
    {
        // Microsoft.EntityFramworkcore

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Employee>().HasKey("EmpId");
            //modelBuilder.Entity<Employee>().HasKey(nameof(Employee.EmpId));
            modelBuilder.Entity<Employee>().HasKey(E => E.EmpId);

            modelBuilder.Entity<Employee>().Property(E => E.Name).IsRequired();
        }
        public AppDbContext() : base()
        {

        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = .; Database = AppEF; Trusted_Connection = True; TrustServerCertificate = True");
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
