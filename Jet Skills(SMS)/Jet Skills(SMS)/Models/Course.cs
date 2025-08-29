using System;
using System.Collections.Generic;

namespace Jet_Skills_SMS_.Models;

public partial class Course
{
    public string CourseId { get; set; } = null!;

    public string CourseName { get; set; } = null!;

    public string? FacultyId { get; set; }

    public int? DurationYears { get; set; }

    public virtual ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();

    public virtual Faculty? Faculty { get; set; }

    public virtual ICollection<Module> Modules { get; set; } = new List<Module>();
}
