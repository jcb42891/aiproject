using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Mvc;
using AIProject.DAL;

namespace AIProject.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(SystemUser user)
        {          
            var context = new AIProjectDBEntities();
            context.SystemUsers.Add(user);
            context.SaveChanges();

            return View();
        }
    }
}