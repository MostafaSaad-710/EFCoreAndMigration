using Assighment.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assighment.Configurations
{
    public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> entity)
        {
            entity.HasKey(d => d.ID);
            entity.Property(d => d.ID).HasColumnName("DeptID");
            entity.Property(d => d.Name).HasMaxLength(100).IsRequired();
            entity.Property(d => d.Ins_ID).IsRequired();
            entity.Property(d => d.HiringDate).HasColumnType("datetime").IsRequired();
        }
    }
}
