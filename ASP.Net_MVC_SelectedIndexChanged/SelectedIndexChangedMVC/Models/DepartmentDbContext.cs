using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;

namespace SelectedIndexChangedMVC.Models
{
    public class DepartmentDbContext:DbContext
    {
        public DbSet<Department> Departments { set; get; }
        public DbSet<Section> Sections { set; get; }
    }
}