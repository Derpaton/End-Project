using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using End_Project.Models;
using End_Project.Global;

namespace End_Project.Controllers {

    public class LoginController : Controller {
        
        public ActionResult Index() {
            Users usr = new Users();
            usr.Name = "NOTEMPTY!";
            return View(usr);
        }

        [HttpPost]
        public ActionResult Create(Users usr) {


            if (!ModelState.IsValid) { return RedirectToAction("Index"); }

            AlbumsContext usrCtx = new AlbumsContext();
            IEnumerable<Users> valid_user = usrCtx.users.Where(u => u.Username == usr.Username &&
            u.Password == usr.Password);

            if (valid_user.Count() == 0) {
                return View();
            }
            
            return RedirectToAction("Login");
        }

        public ActionResult Login() {
            Global_vars.logged_in = true;
            return View();
        }

        public ActionResult Logout() {
            Global_vars.logged_in = false;
            return View();
        }
    }
}
