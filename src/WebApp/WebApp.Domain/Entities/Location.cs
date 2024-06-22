using System;
using System.Collections.Generic;

namespace WebApp;

public partial class Location
{
    public int LocationId { get; set; }

    public string Address { get; set; } = null!;

    public string City { get; set; } = null!;

    public string State { get; set; } = null!;

    public string Country { get; set; } = null!;

    public string? PostalCode { get; set; }

    public virtual GeoLocation? GeoLocation { get; set; }

    public virtual ICollection<UserProfile> UserProfiles { get; set; } = new List<UserProfile>();
}
