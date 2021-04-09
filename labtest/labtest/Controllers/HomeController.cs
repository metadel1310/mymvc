using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace labtest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult login()
        {

            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "About AppFactory student  team.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "contact us by the  following address.";

            return View();
        }
    }
}