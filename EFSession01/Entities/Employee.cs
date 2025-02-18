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

}
