using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewSD.Models
{
    public class SD_Score
    {
        public DateTime Date { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int Total { get; set; }
        public int Place { get; set; }
        public int Work { get; set; }
    }
}