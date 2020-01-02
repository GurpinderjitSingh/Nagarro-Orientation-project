using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class TravelGdCategory
    {
        public TravelGdCategory()
        {
            TravelGdMaster = new HashSet<TravelGdMaster>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<TravelGdMaster> TravelGdMaster { get; set; }
    }
}
