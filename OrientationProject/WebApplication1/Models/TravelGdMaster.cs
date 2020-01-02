using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class TravelGdMaster
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string Address { get; set; }
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }
        public decimal? Altitude { get; set; }
        public string Information { get; set; }
        public byte[] Images { get; set; }
        public string NearestMetro { get; set; }
        public TimeSpan? OpeningTime { get; set; }
        public TimeSpan? ClosingTime { get; set; }
        public int Category { get; set; }

        public virtual TravelGdCategory CategoryNavigation { get; set; }
    }
}
