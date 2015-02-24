using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_HTTP_Student_Department_Section_Information.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }

           [Display(Name = "Name")]
        public string  Name { get; set; }

           [Display(Name = "Location")]
        public string  Location { get; set; }

           [Display(Name = "Student Name")]
        public string StudentId { get; set; }

           [Display(Name = "Section Name")]
        public string SectionId { get; set; }

        public virtual List<Student> Students { get; set; }
        public virtual List<Section> Sections { get; set; } 


    }
}