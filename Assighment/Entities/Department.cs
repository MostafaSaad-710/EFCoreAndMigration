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
    public class Department
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Ins_ID { get; set; }
        public DateTime HiringDate { get; set; }
    }

    //// 2. Data Annotations Way
    //[Table("Departments")]
    //public class DepartmentDataAnnotations
    //{
    //    [Key]
    //    [Column("DepartmentID")]
    //    public int ID { get; set; }

    //    [Required]
    //    [MaxLength(100)]
    //    public string Name { get; set; }

    //    [ForeignKey("Instructor")]
    //    public int Ins_ID { get; set; }

    //    [Column(TypeName = "datetime")]
    //    public DateTime HiringDate { get; set; }
    //}
}
