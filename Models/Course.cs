using System;
using System.Collections.Generic;

namespace ExamSystem.Models;

public partial class Course
{
    public int CourseId { get; set; }

    public int? Duration { get; set; }

    public string? CourseName { get; set; }

    public virtual ICollection<CourseToic> CourseToics { get; } = new List<CourseToic>();

    public virtual ICollection<Exam> Exams { get; } = new List<Exam>();

    public virtual ICollection<Question> Questions { get; } = new List<Question>();

    public virtual ICollection<Department> Departments { get; } = new List<Department>();

    public virtual ICollection<User> Instructors { get; } = new List<User>();

    public virtual ICollection<User> Students { get; } = new List<User>();
}
