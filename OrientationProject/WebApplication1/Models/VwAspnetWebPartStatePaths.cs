using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class VwAspnetWebPartStatePaths
    {
        public Guid ApplicationId { get; set; }
        public Guid PathId { get; set; }
        public string Path { get; set; }
        public string LoweredPath { get; set; }
    }
}
