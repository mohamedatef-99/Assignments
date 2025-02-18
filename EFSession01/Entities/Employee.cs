using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFSession01.Entities
{
    // EF Core Support 4 way for mappping Class in Database: [ Table, view, function]
    // 1. By Convention [Default Behaviour]
    // 2. Data Annotaion [Set of Attributes used for data validation]
    // 3. Fluent API
    // 4. Class Configuration

    // Entity
    // POCO :
    // Plain OLD CLR Object

    // 1. By Convention
    //class Employee
    //{
    //    public int Id { get; set; }  // Public Numeric Property Named 'Id' | 'EmployeeId'  --> PK - Identity constrain
    //    public string Name { get; set; } // Ref Type : Required
    //    public int? Age { get; set; } // Value Type : int - Optional (Allow null)
    //    public double Salary { get; set; } // Value Type : Float - Required
    //    public string? Email { get; set; }  // nvarchar(max) - optional
    //    public DateTime DateOfCreation { get; set; } // datetime2 - required

    //}

    // 2. Data Annotaion
    //[Table("Mohamed", Schema ="dbo")]
    //class Employee
    //{
    //    [Key]
    //    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    //    public int EmpId { get; set; }

    //    [Required]
    //    [Column("EmpName", TypeName = "varchar")]
    //    [MaxLength(50)]
    //    [StringLength(50, MinimumLength = 10)]
    //    public string? Name { get; set; }

    //    [Range(0, 100)]
    //    public int? Age { get; set; }

    //    [EmailAddress]
    //    public string EmailAddress { get; set; }

    //    [Phone]
    //    [DataType(DataType.PhoneNumber)]
    //    public string PhoneNumber { get; set; }

    //    [Column(TypeName = "money")]
    //    [DataType(DataType.Currency)]
    //    public double Salary { get; set; }

    //    [NotMapped]
    //    public double TotalSalary { get; set; }
    //}

    // 3. Fluent API
    class Employee
    {
        public string EmpId { get; set; }
        public string Name { get; set; }
        public int? Age { get; set; }
        public string Email { get; set; }

    }
}
