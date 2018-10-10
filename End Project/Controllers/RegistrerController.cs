using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using End_Project.Models;

namespace End_Project.Controllers
{
    public class RegistrerController : Controller
    {
        // GET: Registrer
        public ActionResult Index()
        {
            return View();
        }

        // GET: Registrer/Create
        public ActionResult Create()
        {
            AlbumsContext usrCtx = new AlbumsContext();
            Users usr = new Users() {
                Name = "ds",
                Username = "sd",
                Password = "fvghnpig"
            };
            usrCtx.users.Add(usr);
            usrCtx.SaveChanges();
            return View();
        }
    }
}
