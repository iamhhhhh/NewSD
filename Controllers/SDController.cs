using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NewSD.Models;


namespace NewSD.Controllers
{
    public class SDController : Controller
    {
        // GET: SD
        public ActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public ActionResult LoginbyUsernameandPassword(string UserName, string Password)
        {
            return View("MyScore");
        }
    }
}