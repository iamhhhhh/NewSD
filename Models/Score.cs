using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewSD.Models
{
    public class Score
    {
         public int SD_ScoreID { get; set; }
        public int SD_UserID { get; set; }
        public string SD_UserDep { get; set; }
        public string SD_UserGroup { get; set; }
        public int SD_SeasonID { get; set; }
        public DateTime SD_FDateScore { get; set; }
        public int SD_DateScore { get; set; }
        public int SD_MonthScore { get; set; }
        public int SD_YearScore { get; set; }
        public DateTime SD_TimeStart { get; set; }
        public DateTime SD_TimeEnd { get; set; }
        public int SD_TotalTime { get; set; }
        public DateTime SD_DateRecord { get; set; }
        public string SD_Group { get; set; }
        public string SD_Category { get; set; }
        public int SD_ScoreReal { get; set; }
        public int SD_ScoreAll { get; set; }
        public int SD_Location { get; set; }
        public int SD_WorkHour { get; set; }
        public string SD_CreatedBy { get; set; }
        public string SD_UpdatedBy { get; set; }
        public DateTime SD_CreatedDate { get; set; }
        public DateTime SD_LastUpdatedDate { get; set; }
        public int SD_Status { get; set; }
    }
}