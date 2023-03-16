using System;
using System.Collections.Generic;

namespace ExamSystem.Models;

public partial class Exam
{
    public int ExamId { get; set; }

    public int? Mark { get; set; }

    public int? CourseId { get; set; }

    public virtual Course? Course { get; set; }

    public virtual ICollection<StudentExamAnswer> StudentExamAnswers { get; } = new List<StudentExamAnswer>();

    public virtual ICollection<StudentExam> StudentExams { get; } = new List<StudentExam>();

    public virtual ICollection<Question> Questions { get; } = new List<Question>();
}
