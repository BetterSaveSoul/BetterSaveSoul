using System;
using System.Collections.Generic;

namespace WebApp;

public partial class UserProfile
{
    public int UserId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public DateOnly DateOfBirth { get; set; }

    public int LocationId { get; set; }

    public string? ProfilePicture { get; set; }

    public string? Bio { get; set; }

    public DateTime DateJoined { get; set; }

    public bool IsActive { get; set; }

    public virtual Location Location { get; set; } = null!;

    public virtual ICollection<Pet> Pets { get; set; } = new List<Pet>();
}
