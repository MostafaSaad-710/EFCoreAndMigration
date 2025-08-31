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
        public class Instructor
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public decimal Bouns { get; set; }
            public decimal Salary { get; set; }
            public string Adress { get; set; }
            public decimal HourRate { get; set; }
            public int Dept_ID { get; set; }
        }

        // 2. Data Annotations Way
      //  [Table("Instructors")]
        //public class InstructorDataAnnotations
        //{
        //    [Key]
        //    [Column("InstructorID")]
        //    public int ID { get; set; }

        //    [Required]
        //    [MaxLength(100)]
        //    public string Name { get; set; }

        //    [Column(TypeName = "decimal(10,2)")]
        //    public decimal Bouns { get; set; }

        //    [Column(TypeName = "decimal(10,2)")]
        //    public decimal Salary { get; set; }

        //    [MaxLength(200)]
        //    public string Adress { get; set; }

        //    [Column(TypeName = "decimal(8,2)")]
        //    public decimal HourRate { get; set; }

        //    [ForeignKey("Department")]
        //    public int Dept_ID { get; set; }
        //}
}

