using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFSession03Demo.Entitis;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFSession03Demo.Configurations
{
    class EmployeeConfigurations : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.Property(E => E.Id).UseIdentityColumn(10, 10);

            builder.HasOne(E => E.WorkFor).WithMany(D => D.Employees).HasForeignKey(E => E.DeptId);
        }
    }
}
