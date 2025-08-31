using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreAndMigration.Entities
{
    //EF Core Support 4 Ways For mapping classes in database: [Tacle , View , Function]
    // 1. By Convention [default Behaviour]
    // 2. Data Annotation [Set of attributes used For Data Validation]
    // 3. Fluent APIS
    // 4. Class Convegration


    /// <summary>
    ///Entity
    /// </summary>
    //POCO : Plain OLD CLR Object

    #region 1. By Convention [default Behaviour]
    ////1. By Convention [default Behaviour]

    //internal class Employee
    //{
    //    public int Id { get; set; }                  // Public Numeric Property Named 'Id' || 'EmployeeId' --> PK  -  identity(1,1)  -  Required
    //    public string Nasme { get; set; }            //Reference Typr - Required [ Not allow Null] - nvarchar(max)
    //    public int? Age { get; set; }                // Nullable Value Type : int[Age] - Optional [Allow Null]
    //    public double Salary { get; set; }           // Vlue Type: float[Salary] - Required
    //    public string? Email { get; set; }           // nvarchar(max) - optional
    //    public DateTime DateOfCreation { get; set; } // Satetime2 - Required 
    //} 
    #endregion

    #region 2. Data Annotation
    ////2. Data Annotation 
    //[Table("Hamada", Schema = "dbo")]
    //internal class Employee
    //{
    //    [Key] // --> "EF Core Recognizes this as PK With Identity
    //    [DatabaseGenerated(DatabaseGeneratedOption.None)] // ---> use this when i don't need identity
    //    public int EmpId { get; set; }


    //    [Required]
    //    [Column("EmpName", TypeName = "varchar")]
    //    [MaxLength(50)]l
    //    [StringLength(50, MinimumLength = 10)]
    //    public string? Nasme { get; set; }


    //    [Range(20, 60)] // it is used as data Validation but it doesn't get mapped to database
    //    public int? Age { get; set; }


    //    [Column(TypeName = "money")]
    //    [DataType(DataType.Currency)] // only Validation
    //    public double Salary { get; set; }


    //    [EmailAddress]  // only Validation
    //    public string? Email { get; set; } //example@example.com


    //    [DataType(DataType.PhoneNumber)] // only Validation
    //    public string PhoneNumber { get; set; }

    //    [NotMapped]
    //    public double TotalSalary { get; set; } // Drived Attrebute

    //    public  string Password { get; set; }

    //} 
    #endregion

    #region 3. Fluent APIS

    internal class Employee
    {
        public int EmpId { get; set; }
        public string Name { get; set; }
        public int? Age { get; set; }
        public double Salary { get; set; }
        public string Email { get; set; }
        public DateTime DateOfCreation { get; set; }
    }

    #endregion

}
