using System;
using System.Collections.Generic;

namespace WebApp;

public partial class GeoLocation
{
    public int LocationId { get; set; }

    public decimal? Latitude { get; set; }

    public decimal? Longitude { get; set; }

    public virtual Location Location { get; set; } = null!;
}
