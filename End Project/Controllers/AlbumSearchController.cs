﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using End_Project.Models;

namespace End_Project.Controllers {

    public class AlbumSearchController : Controller {

        public ActionResult Index() {
            return View();
        }

        public ActionResult Name(string name) {
            AlbumsContext albCtx = new AlbumsContext();
            var album = albCtx.albums.Where(alb => alb.Name.Contains(name) || name == null);
            return View(album);
        }

        public ActionResult Artist(string artist) {
            AlbumsContext albCtx = new AlbumsContext();
            var album = albCtx.albums.Where(alb => alb.Author.Contains(artist) || artist == null);
            return View(album);
        }

        public ActionResult Genre(string genre) {
            AlbumsContext albCtx = new AlbumsContext();
            var album = albCtx.albums.Where(alb => alb.Genre.Contains(genre) || genre == null);
            return View(album);
        }
    }
}