//223 237
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using End_Project.Models;

namespace End_Project.Controllers {

    public class AlbumAddController : Controller {
        public ActionResult Index() {
            Albums alb = new Albums();
            return View(alb);
        }

        [HttpPost]
        public ActionResult Create(Albums alb) {
            if (ModelState.IsValid) {
                AlbumsContext albCtx = new AlbumsContext();
                albCtx.albums.Add(alb);
                albCtx.SaveChanges();

                return View("Create");
            }
            else {
                return View("Index");
            }
        }
    }
}