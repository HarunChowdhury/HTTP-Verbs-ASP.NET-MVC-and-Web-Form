using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_HTTP_Student_Department_Section_Information.Models
{
    public class Section
    {
        public int SectionId{ get; set; }
           [Display(Name = "Name")]
        public string  Name { get; set; }
           [Display(Name = "Student Name")]
        public string StudentId { get; set; }

        public virtual  List< Student>  Students{ get; set; } 
    }
}