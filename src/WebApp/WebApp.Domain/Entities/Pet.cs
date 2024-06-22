using System;
using System.Collections.Generic;

namespace WebApp;

public partial class Pet
{
    public long PetId { get; set; }

    public string? Name { get; set; }

    public int SpeciesId { get; set; }

    public int? BreedId { get; set; }

    public DateOnly DateOfBirth { get; set; }

    public short? Gender { get; set; }

    public string? Color { get; set; }

    public string? Size { get; set; }

    public short HealthStatus { get; set; }

    public bool Vaccinated { get; set; }

    public bool NeuteredStatus { get; set; }

    public string? Description { get; set; }

    public int? OwnerProfileId { get; set; }

    public virtual Breed? Breed { get; set; }

    public virtual Gender? GenderNavigation { get; set; }

    public virtual PetHealthStatus HealthStatusNavigation { get; set; } = null!;

    public virtual UserProfile? OwnerProfile { get; set; }

    public virtual Species Species { get; set; } = null!;
}
