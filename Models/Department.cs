using System;
using System.Collections.Generic;

namespace ExamSystem.Models;

public partial class Department
{
    public int DepartmentId { get; set; }

    public string? DepartmentName { get; set; }

    public virtual ICollection<User> Users { get; } = new List<User>();

    public virtual ICollection<Course> Courses { get; } = new List<Course>();
}
