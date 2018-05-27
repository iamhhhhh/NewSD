using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NewSD.Linq;
using System.Collections;

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
            var User = AuthenAD(UserName, Password);
            if (User != null)
                return View("MyScore");
            else
                return View("Login");
        }

        public SDController()
        {
            context = new OperationDataContext();
        }
        public ActionResult GoMyScore(string UserName)
        {
                return View("MyScore");
        }


        public OperationDataContext context;
        public IEnumerable AuthenAD(string UserName,string Password)
        {

            var query = from User in context.Users
                        where User.UserName == UserName && User.Password == Password
                        select User;
                        

            if (query.Count() > 0)
            {
                return query;
            }
            else
            {
                return null;
            }
            
        }
    }
}