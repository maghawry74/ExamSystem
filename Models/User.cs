using System;
using System.Collections.Generic;

namespace ExamSystem.Models;

public partial class User
{
    public int? DepartmentId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string Ssn { get; set; } = null!;

    public string? Role { get; set; }

    public int? Age { get; set; }

    public string? Password { get; set; }

    public virtual Department? Department { get; set; }

    public virtual ICollection<StudentExamAnswer> StudentExamAnswers { get; } = new List<StudentExamAnswer>();

    public virtual ICollection<StudentExam> StudentExams { get; } = new List<StudentExam>();

    public virtual ICollection<Course> Courses { get; } = new List<Course>();

    public virtual ICollection<Course> CoursesNavigation { get; } = new List<Course>();
}
