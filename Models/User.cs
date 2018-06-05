using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewSD.Models
{
    public class User
    {
        public int SeasonID { get; set; }
        public int UserID { get; set; }
        public string UserFullname { get; set; }
        public string UserNickname { get; set; }
        public string UserLinename { get; set; }
        public DateTime StartDateShake { get; set; }
        public DateTime EndDateShake { get; set; }
        public DateTime StartDateLine { get; set; }
        public DateTime EndDateLine { get; set; }
        public int TeamID { get; set; }
        public string Department { get; set; }
        public string ExceptSD { get; set; }
        public string ExceptLine { get; set; }
        public string MemberStatus { get; set; }
        public string CreatedBy { get; set; }
        public string LastUpdatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public string Status { get; set; }
        public string User_login { get; set; }
        public int UserLevel { get; set; }
        public int SystemLevel { get; set; }



    }
}