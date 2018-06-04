using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NewSD.Linq;
using System.Collections;
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
            var User = AuthenAD(UserName, Password);
            var Allscore = GetAllscorebyID(User.First().UserID);
            if (User != null)
            {
                return View("MyScore");
            }
            else
            {
                ViewBag.Errormessage = "Username or Password is incorrect";
                return View("Login");
            }
        }

        public SDController()
        {
            context = new OperationDataContext();
        }
        public ActionResult GoMyScore(string UserName)
        {
            return View("MyScore");
        }


        public IEnumerable GetAllscorebyID(int id)
        {
            var AllscorebyID = from SD_Score in context.SD_Scores
                               where SD_Score.SD_UserID == id && SD_Score.SD_Status == 'A' && SD_Score.SD_Group == 'S'
                               select SD_Score; 
            return AllscorebyID;
        }

        public OperationDataContext context;
        public List<SD_User> AuthenAD(string UserName,string Password)
        {

            var User = from SD_User in context.SD_Users
                       where SD_User.User_login == UserName && SD_User.Status == 'A'
                       select SD_User;
                        

            if (User.Count() > 0)
            {
                return User.ToList();
            }
            else
            {
                return null;
            }
            
        }
    }
}