using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace End_Project.Controllers
{
    public class AddAlbumController : Controller
    {
        // GET: AddAlbum
        public ActionResult Index()
        {
            return View();
        }

        // GET: AddAlbum/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AddAlbum/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AddAlbum/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: AddAlbum/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AddAlbum/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: AddAlbum/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AddAlbum/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
