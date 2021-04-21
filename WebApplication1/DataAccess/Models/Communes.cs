using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DataAccess.Models
{
    public partial class Communes
    {
        public Communes()
        {
            Address = new HashSet<Address>();
        }

        public int CommuneId { get; set; }
        public string CommuneName { get; set; }
        public int DistrictId { get; set; }
        public string Latitude { get; set; }
        public string Longtitude { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDay { get; set; }
        public string UpdateBy { get; set; }
        public DateTime TimeStamp { get; set; }

        public virtual Districts District { get; set; }
        public virtual ICollection<Address> Address { get; set; }
    }
}
