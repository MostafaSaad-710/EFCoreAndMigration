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
    public class Course_InstConfiguration : IEntityTypeConfiguration<Course_Inst>
    {
        public void Configure(EntityTypeBuilder<Course_Inst> entity)
        {
            entity.HasKey(ci => ci.Course_ID);
            entity.Property(ci => ci.inst_ID).HasColumnName("InstID");
            entity.Property(ci => ci.Course_ID).HasColumnName("CourseID");
            entity.Property(ci => ci.evaluate).HasMaxLength(20);
        }
    }
}
