using System;
using System.Collections.Generic;
using System.Text;

namespace DataModule
{
   public  class DetailProjectsModel
    {
        public int DetailProjectId { get; set; }
        public int UserId { get; set; }
        public int ProjectId { get; set; }
        public double TotalValue { get; set; }
        public DateTime DayStart { get; set; }
        public DateTime DayEnd { get; set; }
        public bool Closed { get; set; }
        public string DetailProjectType { get; set; }
        public string AttachFile { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDay { get; set; }
        public string UpdateBy { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
