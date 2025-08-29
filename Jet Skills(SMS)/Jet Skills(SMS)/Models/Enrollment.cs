using System;
using System.Collections.Generic;

namespace Jet_Skills_SMS_.Models;

public partial class Enrollment
{
    public int EnrollmentId { get; set; }

    public int? StudentId { get; set; }

    public string? CourseId { get; set; }

    public DateOnly? EnrollmentDate { get; set; }

    public virtual Course? Course { get; set; }

    public virtual Student? Student { get; set; }
}
