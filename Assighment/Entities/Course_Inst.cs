using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assighment.Entities
{
    // 1. Convention Way
    public class Course_Inst
    {
        public int inst_ID { get; set; }
        public int Course_ID { get; set; }
        public string evaluate { get; set; }
    }

    //// 2. Data Annotations Way
    //[Table("Course_Instructors_DA")]
    //public class Course_Inst_DataAnnotations
    //{
    //    [Key]
    //    public int inst_ID { get; set; }

    //    [Key]
    //    public int Course_ID { get; set; }

    //    [MaxLength(20)]
    //    public string evaluate { get; set; }
    //}
}
