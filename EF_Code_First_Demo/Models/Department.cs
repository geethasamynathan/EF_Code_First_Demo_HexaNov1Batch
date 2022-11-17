using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EF_Code_First_Demo.Models
{
    public class Department
    {
        //   public int DeptId { get; set; } -- it wont be consider as primary key
        //public int Id { get; set; } -- this  will be considering as primary key with identity
        public int DepartmentId { get; set; }// this this  will be considering as primary key with identity
        [Display(Name="Department Name")]
        [Required (ErrorMessage ="Enter the Name of the Department")]
        public string Name { get; set; }
        public string Location { get; set; }

       // public string DepartmentHead { get; set; }
    }
}