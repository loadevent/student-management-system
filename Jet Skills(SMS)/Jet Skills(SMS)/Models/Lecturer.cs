using System;
using System.Collections.Generic;

namespace Jet_Skills_SMS_.Models;

public partial class Lecturer
{
    public int LecturerId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Email { get; set; }

    public string? PhoneNumber { get; set; }

    public string? FacultyId { get; set; }

    public string? Password { get; set; }

    public int? UserType { get; set; }

    public virtual Faculty? Faculty { get; set; }

    public virtual ICollection<LecturerModule> LecturerModules { get; set; } = new List<LecturerModule>();

    public virtual UserType? UserTypeNavigation { get; set; }
}
