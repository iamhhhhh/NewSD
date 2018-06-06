﻿using System;
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
            ViewData["User"] = User.First();
            ViewBag.Allscore = GetAllscorebyID(User.First().UserID,2);
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


        public IEnumerable GetAllscorebyID(int id, int seasonid)
        {
            var AllscorebyID = from SD_Score in context.SD_Scores
                               where SD_Score.SD_UserID == id && SD_Score.SD_Status == 'A' && SD_Score.SD_Group == 'S' && SD_Score.SD_SeasonID == seasonid
                               orderby SD_Score.SD_FDateScore descending
                               select new Score
                               {
                                   SD_FDateScore = (DateTime)SD_Score.SD_FDateScore.Value.Date,
                                   SD_TimeStart = (DateTime)SD_Score.SD_TimeStart,
                                   SD_TimeEnd = (DateTime)SD_Score.SD_TimeEnd,
                                   SD_TotalTime = (int)SD_Score.SD_TotalTime,
                                   SD_WorkHour = (int)SD_Score.SD_WorkHour,
                                   SD_Location = (int)SD_Score.SD_Location

                               }; 
            return AllscorebyID.ToList();
        }

        public OperationDataContext context;
        public IEnumerable<User> AuthenAD(string UserName,string Password)
        {

            var User = from SD_User in context.SD_Users
                       where SD_User.User_login == UserName && SD_User.Status == 'A'
                       select new User
                       {
                           UserFullname = SD_User.UserFullname,
                           UserID = SD_User.UserID,
                           TeamID = (int)SD_User.TeamID,
                           SeasonID = SD_User.SeasonID
                       };

            if (User.Count() > 0)
            {
                return User.ToList();
            }
            else
                return null;
        }
    }
}