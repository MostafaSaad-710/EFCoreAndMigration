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
    public class Topic
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

    // 2. Data Annotations Way
    //[Table("Topics")]
    //public class TopicDataAnnotations
    //{
    //    [Key]
    //    [Column("TopicID")]
    //    public int ID { get; set; }

    //    [Required]
    //    [MaxLength(100)]
    //    public string Name { get; set; }
    //}
}
