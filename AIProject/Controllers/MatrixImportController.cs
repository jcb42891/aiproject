using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AIProject.Controllers
{
    public class MatrixImportController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(HttpPostedFileBase aiMatrixFU)
        {
            if (aiMatrixFU.ContentLength > 0)
            {
                var fileName = Path.GetFileName(aiMatrixFU.FileName);
                var path = Path.Combine(Server.MapPath("~/App_Data/Uploads"), fileName);
                aiMatrixFU.SaveAs(path);
            }
            // test
            return View();
        }
    }
}