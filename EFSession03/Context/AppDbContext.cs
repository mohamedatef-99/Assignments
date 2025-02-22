using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFSession03.Models;
using Microsoft.EntityFrameworkCore;

namespace EFSession03.Context
{
    class AppDbContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // TPH
            //modelBuilder.Entity<FullTimeEmployee>().HasBaseType<Employee>();
            //modelBuilder.Entity<PartTimeEmployee>().HasBaseType<Employee>();

            // TPC
            //modelBuilder.Entity<Employee>().ToTable("Employees");
            //modelBuilder.Entity<FullTimeEmployee>().ToTable("FullTimeEmployees");
            //modelBuilder.Entity<PartTimeEmployee>().ToTable("PartTimeEmployees");

            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = .; Database = Inheritance; Trusted_Connection = True; TrustServerCertificate = True");

        }

        // TPCC
        //public DbSet<Employee> Employees { get; set; }
        public DbSet<FullTimeEmployee> FullTimeEmployees { get; set; }
        public DbSet<PartTimeEmployee> PartTimeEmployees { get; set; }
    }
}
