using System;
using System.Collections.Generic;

namespace WebApp;

public partial class Image
{
    public int ImageId { get; set; }

    public string ImageUrl { get; set; } = null!;

    public DateTime Created { get; set; }
}
