using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Services.Description;

namespace MVC_HTTP_Student_Department_Section_Information.Models
{
    public class DepartmentDbContext:DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<Department> Departments { get; set; }


    }
}