using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DataAccess.Models
{
    public partial class Districts
    {
        public Districts()
        {
            Address = new HashSet<Address>();
            Communes = new HashSet<Communes>();
        }

        public int DistrictId { get; set; }
        public int CityId { get; set; }
        public string DistrictName { get; set; }
        public string Latitude { get; set; }
        public string Longtitude { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDay { get; set; }
        public string UpdateBy { get; set; }
        public DateTime TimeStamp { get; set; }

        public virtual Citys City { get; set; }
        public virtual ICollection<Address> Address { get; set; }
        public virtual ICollection<Communes> Communes { get; set; }
    }
}
