using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AIProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Worth $1B";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "For questions about insurance, call Art.";

            return View();
        }
    }
}