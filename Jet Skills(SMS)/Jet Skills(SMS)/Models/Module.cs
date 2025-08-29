using System;
using System.Collections.Generic;

namespace Jet_Skills_SMS_.Models;

public partial class Module
{
    public string ModuleId { get; set; } = null!;

    public string ModuleName { get; set; } = null!;

    public string? CourseId { get; set; }

    public int? Semester { get; set; }

    public virtual Course? Course { get; set; }

    public virtual ICollection<LecturerModule> LecturerModules { get; set; } = new List<LecturerModule>();
}
