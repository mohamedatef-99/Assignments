using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFSession02.Configurations;
using EFSession02.Entities;
using Microsoft.EntityFrameworkCore;

namespace EFSession02.Context
{
    class AppDbContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            base.OnModelCreating(modelBuilder);
        }
        public AppDbContext() : base()
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = .; Database = AppEF02; Trusted_Connection = True; TrustServerCertificate = True");
        }
        public DbSet<Employee> Employee { get; set; }
    }
}
