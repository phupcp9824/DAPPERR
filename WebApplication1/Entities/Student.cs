using System;
using System.Collections.Generic;

namespace WebApplication1.Entities;

public partial class Student
{
    public int StudentId { get; set; }

    public string Name { get; set; } = null!;

    public int? Age { get; set; }

    public string? Address { get; set; }

    public string Phone { get; set; } = null!;
}
