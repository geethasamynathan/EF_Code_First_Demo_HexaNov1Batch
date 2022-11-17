using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EF_Code_First_Demo.Models
{
    public class DepartmentContext:DbContext
    {
        public DepartmentContext():base("myconnection")
        {

        }
      

        //table need to create in Db
        public DbSet<Department> Departments { get; set; }
    }
}