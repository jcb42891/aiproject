using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using AIProject.DAL;
using System.Data.Entity;
using AIProject.Classes;
using System.Data;

namespace AIProject
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            
            ///  ** CODE FOR IMPORTING THE MATRIX **
            //DataTable AIMatrix_CSV =  Utility.csvToDataTable(@"C:\Source\aiproject\aimatrix.csv");

            //var context = new AIProjectDBEntities();

            //foreach (DataRow row in AIMatrix_CSV.Rows)
            //{
            //    AIMatrix matrix = AIMatrixMapper.mapMatrixRow(row);
            //    context.AIMatrix.Add(matrix);
            //}
            //try
            //{
            //    context.SaveChanges();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
            

        }
    }
}
