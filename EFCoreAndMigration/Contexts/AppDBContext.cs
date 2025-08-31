using EFCoreAndMigration.Configurations;
using EFCoreAndMigration.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreAndMigration.Contexts
{
    internal class AppDBContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder m)
        {
            #region 3.
            //m.Entity<Employee>().HasKey(E => E.EmpId);

            //m.Entity<Employee>()
            // .Property(E => E.Name)
            // .IsRequired()
            // .HasColumnType("varchar")
            // .HasMaxLength(50)
            // .HasJsonPropertyName("EmpName");

            //m.Entity<Employee>().Property(E => E.Age).IsRequired(false);

            //m.Entity<Employee>().Property(E => E.Salary).HasColumnType("money");

            //m.Entity<Employee>().Property(E => E.DateOfCreation).HasDefaultValueSql("GETDATE()");

            //base.OnModelCreating(m);

            //m.Entity<Employee>(E =>

            //{
            //    E.HasKey(E => E.EmpId);

            //    E.Property(E => E.Name)
            //     .IsRequired()
            //     .HasColumnType("varchar")
            //     .HasMaxLength(50)
            //     .HasJsonPropertyName("EmpName");

            //    E.Property(E => E.Age).IsRequired(false);

            //    E.Property(E => E.Salary).HasColumnType("money");

            //    E.Property(E => E.DateOfCreation).HasDefaultValueSql("GETDATE()");

            //}); 
            #endregion

            m.ApplyConfiguration(new EmployeeConfigurations());

            base.OnModelCreating(m);


        }

        public AppDBContext() : base()
        { 
        
        }

        // by using OnConfiguring i can connect to database
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = . ; Database = SessionMigration ; Trusted_Connection = True ; TrustServerCertificate = True ");
        }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Department> Departments { get; set; }



    } 
}
