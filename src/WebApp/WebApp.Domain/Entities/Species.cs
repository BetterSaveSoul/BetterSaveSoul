using System;
using System.Collections.Generic;

namespace WebApp;

public partial class Species
{
    public int SpeciesId { get; set; }

    public string Name { get; set; } = null!;

    public string Aname { get; set; } = null!;

    public virtual ICollection<Breed> Breeds { get; set; } = new List<Breed>();

    public virtual ICollection<Pet> Pets { get; set; } = new List<Pet>();
}
