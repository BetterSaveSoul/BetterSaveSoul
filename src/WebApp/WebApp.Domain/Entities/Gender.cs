using System;
using System.Collections.Generic;

namespace WebApp;

public partial class Gender
{
    public short GenderId { get; set; }

    public string GenderName { get; set; } = null!;

    public string GenderAname { get; set; } = null!;

    public virtual ICollection<Pet> Pets { get; set; } = new List<Pet>();
}
