using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace End_Project.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home yes
        public ActionResult Index()
        {
            return View();
        }
    }
}