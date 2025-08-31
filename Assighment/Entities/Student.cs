using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assighment.Entities
{
    // 1. Convention Way (Default EF Rules)
    public class Student
    {
        public int ID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public int Dep_Id { get; set; }
    }

    // 2. Data Annotations Way
    //[Table("Students")]
    //public class StudentDataAnnotations
    //{
    //    [Key]
    //    [Column("StudentID")]
    //    public int ID { get; set; }

    //    [Required]
    //    [MaxLength(50)]
    //    [Column("FirstName")]
    //    public string FName { get; set; }

    //    [Required]
    //    [MaxLength(50)]
    //    [Column("LastName")]
    //    public string LName { get; set; }

    //    [MaxLength(200)]
    //    public string Address { get; set; }

    //    [Range(18, 100)]
    //    public int Age { get; set; }

    //    [ForeignKey("Department")]
    //    public int Dep_Id { get; set; }
    //}
}
