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
    public class Stud_CourseConfiguration : IEntityTypeConfiguration<Stud_Course>
    {
        public void Configure(EntityTypeBuilder<Stud_Course> entity)
        {
            entity.HasKey(sc => sc.Course_ID);
            entity.Property(sc => sc.stud_ID).HasColumnName("StudID");
            entity.Property(sc => sc.Course_ID).HasColumnName("CourseID");
            entity.Property(sc => sc.Grade).HasMaxLength(10);
        }
    }
}
