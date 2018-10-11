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
            Users usr = new Users();
            return View(usr);
        }

        // GET: Registrer/Create
        public ActionResult Create(Users usr) {
            if (ModelState.IsValid) {
                AlbumsContext albCtx = new AlbumsContext();
                albCtx.users.Add(usr);
                albCtx.SaveChanges();

                return View();
            }
            else {
                return View("Index");
            }
        }
    }
}



