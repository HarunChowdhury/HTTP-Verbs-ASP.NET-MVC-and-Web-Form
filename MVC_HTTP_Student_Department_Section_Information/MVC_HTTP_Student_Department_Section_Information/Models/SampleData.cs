using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Microsoft.Owin.BuilderProperties;

namespace MVC_HTTP_Student_Department_Section_Information.Models
{
    public class SampleData:DropCreateDatabaseIfModelChanges<DepartmentDbContext>
    {
        protected override void Seed(DepartmentDbContext context)
        {
            var students = new List<Student>
            {new Student()
            { Name = "Kamal", RegNo = "ST_000144", Address = "Dhaka Polli", HallName = "BBH"},
             new Student() { Name = "Jamal", RegNo = "ST_000214",Address = "Gajipur Polli", HallName = "RJ" }
            };

            students.ForEach(aStudent=>context.Students.Add(aStudent));
            context.SaveChanges();
            var sections = new List<Section>
            {
                new Section() { Name = "Banana Section", StudentId = "ST_000144" },
                new Section() { Name = "Apple Section", StudentId = "ST_000214" }
            };

            sections.ForEach(aSection => context.Sections.Add(aSection));
            context.SaveChanges();
            var departments = new List<Department>
            {
                new Department() { Name = "CSE", Location = "Near BBH", StudentId = "ST_000144", SectionId = "Banana Section" } ,
               new Department() { Name = "EE", Location = "Near New Art", StudentId = "ST_000214", SectionId = "Apple Section" } 
            };
            departments.ForEach(aDepartment => context.Departments.Add(aDepartment));
            
            context.SaveChanges();
        }
    }
}