using System;
using System.Collections.Generic;

namespace ExamSystem.Models;

public partial class StudentExamAnswer
{
    public int ExamId { get; set; }

    public string StudentId { get; set; } = null!;

    public int QuestionId { get; set; }

    public string? Answer { get; set; }

    public virtual Exam Exam { get; set; } = null!;

    public virtual Question Question { get; set; } = null!;

    public virtual User Student { get; set; } = null!;
}
