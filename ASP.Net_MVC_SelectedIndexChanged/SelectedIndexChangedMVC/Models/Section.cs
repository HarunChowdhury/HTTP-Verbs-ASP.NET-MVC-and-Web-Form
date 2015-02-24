using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SelectedIndexChangedMVC.Models
{
    public class Section
    {
        public int SectionId { set; get; }
        public int DepartmentId { set; get; }
        [Required(ErrorMessage = "Code missing")]
        public string Code { set; get; }
        public string Description { set; get; }
        public virtual Department Department { set; get; }

    }
}