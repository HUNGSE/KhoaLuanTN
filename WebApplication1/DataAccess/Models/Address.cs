using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DataAccess.Models
{
    public partial class Address
    {
        public Address()
        {
            Projects = new HashSet<Projects>();
            Users = new HashSet<Users>();
        }

        public int AddressId { get; set; }
        public int DistrictId { get; set; }
        public int CityId { get; set; }
        public int CommuneId { get; set; }
        public string Street { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDay { get; set; }
        public string UpdateBy { get; set; }
        public DateTime TimeStamp { get; set; }

        public virtual Citys City { get; set; }
        public virtual Communes Commune { get; set; }
        public virtual Districts District { get; set; }
        public virtual ICollection<Projects> Projects { get; set; }
        public virtual ICollection<Users> Users { get; set; }
    }
}
