using System;
using System.Collections.Generic;

namespace EF_Lec1.Models;

public partial class Student
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? Age { get; set; }

    public string? Address { get; set; }

    public int DeptId { get; set; }

    public virtual Department Dept { get; set; } = null!;
}
