using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PaymentsDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Use this site to test out Payment Provider integrations and view sample code as you navigate the payment pipeline.";

            return View();
        }


        public ActionResult Providers()
        {
            ViewBag.Message = "  We're currently working on our first integration, check back to see the links below light up and also to explore additional payment providers.";

            return View();
        }


        public ActionResult Contact()
        {
            ViewBag.Message = "";

            return View();
        }
    }
}
