using System;
using System.Collections.Generic;

namespace ExamSystem.Models;

public partial class CourseToic
{
    public int TopicId { get; set; }

    public string? TopicName { get; set; }

    public int? CourseId { get; set; }

    public virtual Course? Course { get; set; }
}
