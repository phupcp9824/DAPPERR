using System;
using System.Collections.Generic;

namespace DAPPERR.Entities;

public partial class Teacher
{
    public int TeacherId { get; set; }

    public string NameTeacher { get; set; } = null!;

    public int? Age { get; set; }

    public string? Address { get; set; }

    public string Phone { get; set; } = null!;
}
