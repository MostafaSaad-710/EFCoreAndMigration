using Assighment.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assighment.Contexts
{
    internal class AppDbContext : DbContext
    {
        #region Fluent
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{

        //    // Student Fluent API
        //    modelBuilder.Entity<Student>(entity =>
        //    {
        //        entity.HasKey(s => s.ID);
        //        entity.Property(s => s.ID).HasColumnName("StudID");
        //        entity.Property(s => s.FName).HasMaxLength(50).IsRequired();
        //        entity.Property(s => s.LName).HasMaxLength(50).IsRequired();
        //        entity.Property(s => s.Address).HasMaxLength(100);
        //        entity.Property(s => s.Age).IsRequired();
        //        entity.Property(s => s.Dep_Id).IsRequired();
        //    });

        //    // Course Fluent API
        //    modelBuilder.Entity<Course>(entity =>
        //    {
        //        entity.HasKey(c => c.ID);
        //        entity.Property(c => c.ID).HasColumnName("CourseID");
        //        entity.Property(c => c.Duration).IsRequired();
        //        entity.Property(c => c.Name).HasMaxLength(100).IsRequired();
        //        entity.Property(c => c.Description).HasMaxLength(500);
        //        entity.Property(c => c.Top_ID).IsRequired();
        //    });

        //    // Department Fluent API
        //    modelBuilder.Entity<Department>(entity =>
        //    {
        //        entity.HasKey(d => d.ID);
        //        entity.Property(d => d.ID).HasColumnName("DeptID");
        //        entity.Property(d => d.Name).HasMaxLength(100).IsRequired();
        //        entity.Property(d => d.Ins_ID).IsRequired();
        //        entity.Property(d => d.HiringDate).HasColumnType("datetime").IsRequired();
        //    });

        //    // Instructor Fluent API
        //    modelBuilder.Entity<Instructor>(entity =>
        //    {
        //        entity.HasKey(i => i.ID);
        //        entity.Property(i => i.ID).HasColumnName("InsID");
        //        entity.Property(i => i.Name).HasMaxLength(100).IsRequired();
        //        entity.Property(i => i.Bouns).HasColumnType("decimal(10,2)");
        //        entity.Property(i => i.Salary).HasColumnType("decimal(10,2)").IsRequired();
        //        entity.Property(i => i.Adress).HasMaxLength(100);
        //        entity.Property(i => i.HourRate).HasColumnType("decimal(8,2)");
        //        entity.Property(i => i.Dept_ID).IsRequired();
        //    });

        //    // Topic Fluent API
        //    modelBuilder.Entity<Topic>(entity =>
        //    {
        //        entity.HasKey(t => t.ID);
        //        entity.Property(t => t.ID).HasColumnName("TopicID");
        //        entity.Property(t => t.Name).HasMaxLength(100).IsRequired();
        //    });

        //    // Stud_Course Fluent API
        //    modelBuilder.Entity<Stud_Course>(entity =>
        //    {
        //        entity.HasKey(sc => sc.Course_ID );
        //        entity.Property(sc => sc.stud_ID).HasColumnName("StudID");
        //        entity.Property(sc => sc.Course_ID).HasColumnName("CourseID");
        //        entity.Property(sc => sc.Grade).HasMaxLength(10);
        //    });

        //    // Course_Inst Fluent API
        //    modelBuilder.Entity<Course_Inst>(entity =>
        //    {
        //        entity.HasKey(ci => ci.Course_ID );
        //        entity.Property(ci => ci.inst_ID).HasColumnName("InstID");
        //        entity.Property(ci => ci.Course_ID).HasColumnName("CourseID");
        //        entity.Property(ci => ci.evaluate).HasMaxLength(20);
        //    });

        //    base.OnModelCreating(modelBuilder);
        //} 
        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = . ; Database = AssignmentMigration ; Trusted_Connection = True ; TrustServerCertificate = True ");
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Stud_Course> Stud_Courses { get; set; }
        public DbSet<Course_Inst> Course_Insts { get; set; }

    }
}
