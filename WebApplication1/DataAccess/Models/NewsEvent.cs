using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DataAccess.Models
{
    public partial class NewsEvent
    {
        public int NewsEventId { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public int ProjectId { get; set; }

        public virtual Projects Project { get; set; }
    }
}
