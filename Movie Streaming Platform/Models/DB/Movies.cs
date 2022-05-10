using System;
using System.Collections.Generic;

namespace Movie_Streaming_Platform.Models.DB
{
    public partial class Movies
    {
        public int MovieId { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string ReleaseDate { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
