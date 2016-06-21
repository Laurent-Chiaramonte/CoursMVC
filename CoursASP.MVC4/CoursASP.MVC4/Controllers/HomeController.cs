using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CoursASP.MVC4.Models;

namespace CoursASP.MVC4.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            MesDonnees odatas = new MesDonnees();
            string strMessage = odatas.GetDonnees();
            ViewData["message"] = strMessage;
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