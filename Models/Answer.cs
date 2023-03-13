using System;
using System.Collections.Generic;

namespace ExamSystem.Models;

public partial class Answer
{
    public int QuestionId { get; set; }

    public string QuestionAnswer { get; set; } = null!;

    public virtual Question Question { get; set; } = null!;
}
