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
            
            var Allscore = GetAllscorebyID(User.UserID);
            if (User != null)
                return View("MyScore",User);
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
        public dynamic AuthenAD(string UserName,string Password)
        {

            var User = from SD_User in context.SD_Users
                       where SD_User.User_login == UserName && SD_User.Status == 'A'
                       select new User
                       {
                           UserID = SD_User.UserID,
                           UserFullname = SD_User.UserFullname,
                           Department = SD_User.Department,
                           SeasonID = SD_User.SeasonID,
                           User_login = SD_User.User_login
                        };
                        

            if (User.Count() > 0)
            {
                return User;
            }
            else
            {
                return null;
            }
            
        }
    }
}