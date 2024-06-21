using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class Comment
{
    public int CommentId { get; set; }

    public string? CommentName { get; set; }

    public int? VideoId { get; set; }

    public string? VideoUrl { get; set; }

    public int? UserId { get; set; }

    public string? UserName { get; set; }
}
