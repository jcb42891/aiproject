using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Mvc;
using AIProject.DAL;

namespace AIProject.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(SystemUser user)
        {
            var context = new AIProjectDBEntities();
            IEnumerable<SystemUser> userLoggingIn = context.SystemUserCheckLogin(user.Username, user.Password);

            bool isValidUser = false;
            foreach (SystemUser u in userLoggingIn)
            {
                user = u;
                isValidUser = true;
                break;
            }

            if (isValidUser)
            {
                return View(user);
            }
            else
            {
                return View();
            }            
        }
        
        [HttpGet]
        public ActionResult Create()
        {
            // Check if user is logged in

            return View();
        }

        [HttpPost]
        public ActionResult Create(SystemUser user)
        {          
            var context = new AIProjectDBEntities();
            context.SystemUser.Add(user);
            context.SaveChanges();

            return View("Index", user);
        }
    }
}