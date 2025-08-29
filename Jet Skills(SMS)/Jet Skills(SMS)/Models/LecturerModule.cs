using System;
using System.Collections.Generic;

namespace Jet_Skills_SMS_.Models;

public partial class LecturerModule
{
    public int AssignmentId { get; set; }

    public string? ModuleId { get; set; }

    public int? LecturerId { get; set; }

    public string? AcademicYear { get; set; }

    public virtual Lecturer? Lecturer { get; set; }

    public virtual Module? Module { get; set; }
}
