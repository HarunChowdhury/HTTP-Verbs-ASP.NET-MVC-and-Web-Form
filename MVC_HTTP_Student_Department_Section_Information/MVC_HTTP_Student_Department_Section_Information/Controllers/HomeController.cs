using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_HTTP_Student_Department_Section_Information.Models;

namespace MVC_HTTP_Student_Department_Section_Information.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        //public ActionResult Student() 
        //{
        //    return View();
        //}

        //public ActionResult Section()
        //{


        //    return View(" http://localhost:1310/Section/Create");
        //}

        //public ActionResult Department() 
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}
    }
}