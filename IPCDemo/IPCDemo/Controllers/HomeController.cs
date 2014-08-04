using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IPCDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //Change 1 in the master branch
            //Change 1 in Branch 1
            //Change 1 in Brach 2
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
    }
}