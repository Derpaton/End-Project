using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace End_Project.Controllers
{
    public class ListAlbumController : Controller
    {
        // GET: ListAlbum
        public ActionResult Index()
        {
            return View();
        }

        // GET: ListAlbum/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ListAlbum/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ListAlbum/Create
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

        // GET: ListAlbum/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ListAlbum/Edit/5
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

        // GET: ListAlbum/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ListAlbum/Delete/5
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
