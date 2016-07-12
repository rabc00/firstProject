using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace firstProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Playing With C#";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Blog() 
        {
            ViewBag.Message = "Your Blog Page";

            return View();
        }
        public ActionResult Search()
        {
            ViewBag.Message = "Your Search Page";

            return View();
        }
        public ActionResult Feedb() 
        {
            ViewBag.Message = "Feed Me Back.";

            return View();
        }
        public ActionResult FAQ() 
        {
            ViewBag.Message = "Ask Me, Ask Me.";

            return View();
        }

    }
}
