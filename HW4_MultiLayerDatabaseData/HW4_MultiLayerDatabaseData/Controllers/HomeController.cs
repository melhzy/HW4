using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer;
using DataAccessLayer;
using Models;

namespace HW4_MultiLayerDatabaseData.Controllers
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

        public ActionResult DisplayData()
        {
            ViewBag.Message = "Display individual information.";

            var IndivDemo = DemoInformation.GetDemoData();

            return View(IndivDemo);
        }
    }
}