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
        public ActionResult MyScore(string UserName, string Password)
        {
            if (AuthenAD(UserName, Password) == true)
                return View("MyScore");
            else
                return View("Login");
        }

        public ActionResult GoMyScore()
        {
                return View("MyScore");
        }



        public Boolean AuthenAD(string UserName,string Password)
        {
            if ( 0==0)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}