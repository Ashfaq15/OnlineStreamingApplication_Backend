using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class Admin
{
    public int Id { get; set; }

    public string? AdminName { get; set; }

    public string? AdminEmail { get; set; }

    public string? AdminPassword { get; set; }
}
