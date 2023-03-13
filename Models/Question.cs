using System;
using System.Collections.Generic;

namespace ExamSystem.Models;

public partial class Question
{
    public int QuestionId { get; set; }

    public string? Body { get; set; }

    public string? ModelAnswer { get; set; }

    public int? Grade { get; set; }

    public string? Type { get; set; }

    public int? CourseId { get; set; }

    public virtual ICollection<Answer> Answers { get; } = new List<Answer>();

    public virtual Course? Course { get; set; }

    public virtual ICollection<Exam> Exams { get; } = new List<Exam>();
}
