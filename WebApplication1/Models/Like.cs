using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class Like
{
    public int LikeId { get; set; }

    public string? VideoName { get; set; }

    public string? VideoUrl { get; set; }

    public int? VideoId { get; set; }

    public int? UserId { get; set; }

    public string? UserName { get; set; }
}
