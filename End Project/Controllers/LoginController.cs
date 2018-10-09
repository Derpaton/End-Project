using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using End_Project.Models;

namespace End_Project.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index(Users u)
        {
            return View(u);
        }
    }
}
