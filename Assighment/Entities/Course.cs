using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assighment.Entities
{
    // 1. Convention Way
    public class Course
    {
        public int ID { get; set; }
        public int Duration { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Top_ID { get; set; }
    }

    //// 2. Data Annotations Way
    //[Table("Courses")]
    //public class CourseDataAnnotations
    //{
    //    [Key]
    //    [Column("CourseID")]
    //    public int ID { get; set; }

    //    public int Duration { get; set; }

    //    [Required]
    //    [MaxLength(100)]
    //    public string Name { get; set; }

    //    [MaxLength(500)]
    //    public string Description { get; set; }

    //    [ForeignKey("Topic")]
    //    public int Top_ID { get; set; }
    //}
}
