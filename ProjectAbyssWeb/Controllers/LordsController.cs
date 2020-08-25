using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectAbyssWeb.Controllers
{
    public class LordsController : Controller
    {
        // GET: Lords

        [HttpPost]
        public ActionResult Index()
        {
            Console.WriteLine("Test");
            return View();
        }
    }
}