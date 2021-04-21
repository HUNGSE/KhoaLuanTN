using System;
using System.Collections.Generic;
using System.Text;

namespace DataModule
{
    public class DistrictsModel
    {
        public int DistrictId { get; set; }
        public int CityId { get; set; }
        public string DistrictName { get; set; }
        public string Latitude { get; set; }
        public string Longtitude { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDay { get; set; }
        public string UpdateBy { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
