using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class UsersDatum
{
    public int UserId { get; set; }

    public string? UserName { get; set; }

    public string UserEmail { get; set; } = null!;

    public string? UserPassword { get; set; }
}
