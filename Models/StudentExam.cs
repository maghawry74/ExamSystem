using System;
using System.Collections.Generic;

namespace ExamSystem.Models;

public partial class StudentExam
{
    public int ExamId { get; set; }

    public string StudentId { get; set; } = null!;

    public int? StudentGrade { get; set; }

    public virtual Exam Exam { get; set; } = null!;

    public virtual User Student { get; set; } = null!;
}
