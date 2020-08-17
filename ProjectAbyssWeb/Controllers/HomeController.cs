using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectAbyssWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ConfigPlayers()
        {
            return View();
        }

        public ActionResult AddElement()
        {
            return View();
        }

        public ActionResult DisplaySetup()
        {
            return View("Setup");
        }
    }
}