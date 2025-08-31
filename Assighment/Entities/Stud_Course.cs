using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assighment.Entities
{
    public class Stud_Course
    {
        public int stud_ID { get; set; }
        public int Course_ID { get; set; }
        public string Grade { get; set; }
    }

    // 2. Data Annotations Way
    //[Table("Student_Courses_DA")]
    //public class Stud_Course_DataAnnotations
    //{
    //    [Key ]
    //    public int stud_ID { get; set; }

    //    [Key]
    //    public int Course_ID { get; set; }

    //    [MaxLength(10)]
    //    public string Grade { get; set; }
    //}
}
