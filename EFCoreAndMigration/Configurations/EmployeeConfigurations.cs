using EFCoreAndMigration.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreAndMigration.Configurations
{
    internal class EmployeeConfigurations : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> E)
        {
            E.HasKey(E => E.EmpId);

            E.Property(E => E.Name)
             .IsRequired()
             .HasColumnType("varchar")
             .HasMaxLength(50)
             .HasJsonPropertyName("EmpName");

            E.Property(E => E.Age).IsRequired(false);

            E.Property(E => E.Salary).HasColumnType("money");

            E.Property(E => E.DateOfCreation).HasDefaultValueSql("GETDATE()"); ;
        }
    }
}
