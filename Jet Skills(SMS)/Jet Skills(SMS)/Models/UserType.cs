using System;
using System.Collections.Generic;

namespace Jet_Skills_SMS_.Models;

public partial class UserType
{
    public int UserTypeId { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<Lecturer> Lecturers { get; set; } = new List<Lecturer>();

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();
}
