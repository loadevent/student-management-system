using System;
using System.Collections.Generic;

namespace Jet_Skills_SMS_.Models;

public partial class Student
{
    public int StudentId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Email { get; set; }

    public string? PhoneNumber { get; set; }

    public DateOnly? DateOfBirth { get; set; }

    public string? Gender { get; set; }

    public DateOnly? EnrollmentDate { get; set; }

    public string? Password { get; set; }

    public int? UserType { get; set; }

    public virtual ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();

    public virtual UserType? UserTypeNavigation { get; set; }
}
