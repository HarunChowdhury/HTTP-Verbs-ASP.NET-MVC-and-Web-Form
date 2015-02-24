using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_HTTP_Student_Department_Section_Information.Models
{
    public class Student
    {
        public int StudentId { get; set; }

        [Display(Name = "Name")]
        public string  Name { get; set; }
           [Display(Name = "Registration No")]
        public string  RegNo { get; set; }
           [Display(Name = "Address")]
        public string  Address { get; set; }
           [Display(Name = "Hall Name")]
        public string  HallName { get; set; }
    }
}