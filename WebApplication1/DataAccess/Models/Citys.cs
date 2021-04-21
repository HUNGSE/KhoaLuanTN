using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DataAccess.Models
{
    public partial class Citys
    {
        public Citys()
        {
            Address = new HashSet<Address>();
            Districts = new HashSet<Districts>();
        }

        public int CityId { get; set; }
        public string CityName { get; set; }
        public string Latitude { get; set; }
        public string Longtitude { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDay { get; set; }
        public string UpdateBy { get; set; }
        public DateTime TimeStamp { get; set; }

        public virtual ICollection<Address> Address { get; set; }
        public virtual ICollection<Districts> Districts { get; set; }
    }
}
