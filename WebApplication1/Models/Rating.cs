using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class Rating
{
    public int RatingId { get; set; }

    public int? RatingNumber { get; set; }

    public int? VideoId { get; set; }

    public string? VideoUrl { get; set; }

    public string? VideoName { get; set; }

    public int? UserId { get; set; }

    public string? UserName { get; set; }
}
