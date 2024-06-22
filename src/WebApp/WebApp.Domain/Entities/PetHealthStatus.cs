using System;
using System.Collections.Generic;

namespace WebApp;

public partial class PetHealthStatus
{
    public short PetHealthStatusId { get; set; }

    public string HealthStatus { get; set; } = null!;

    public string AhealthStatus { get; set; } = null!;

    public virtual ICollection<Pet> Pets { get; set; } = new List<Pet>();
}
