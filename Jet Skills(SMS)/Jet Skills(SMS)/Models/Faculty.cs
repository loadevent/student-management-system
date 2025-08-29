using System;
using System.Collections.Generic;

namespace Jet_Skills_SMS_.Models;

public partial class Faculty
{
    public string FacultyId { get; set; } = null!;

    public string FacultyName { get; set; } = null!;

    public string? DeanName { get; set; }

    public virtual ICollection<Course> Courses { get; set; } = new List<Course>();

    public virtual ICollection<Lecturer> Lecturers { get; set; } = new List<Lecturer>();
}
