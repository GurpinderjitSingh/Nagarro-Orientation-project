using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class TravelGdBlogs
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte[] Images { get; set; }
        public DateTime? PostedTime { get; set; }
        public int? Likes { get; set; }
        public int? Dislikes { get; set; }
        public Guid? PostedBy { get; set; }

        public virtual AspnetMembership PostedByNavigation { get; set; }
    }
}
