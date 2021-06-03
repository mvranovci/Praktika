using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Praktika.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
<<<<<<< HEAD
 
=======

>>>>>>> db7cb057b43d0ae8e79dcaa708bb87c492a7bc8c
            ViewBag.Message = "Your application description page. hello world";
 

            return View();
        }

        public ActionResult Contact() 
        {
            ViewBag.Message = "Your contact page. test1.";

            return View();
        }
    }
}