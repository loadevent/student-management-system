using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Jet_Skills_SMS_.Models;

public partial class Course
{
    [Key]
    [Column("course_id")]
    [StringLength(50)]
    [Unicode(false)]
    public string CourseId { get; set; } = null!;

    [Column("course_name")]
    [StringLength(100)]
    [Unicode(false)]
    public string CourseName { get; set; } = null!;

    [Column("faculty_id")]
    [StringLength(15)]
    [Unicode(false)]
    public string? FacultyId { get; set; }

    [Column("duration_years")]
    public int? DurationYears { get; set; }

    [InverseProperty("Course")]
    public virtual ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();

    [ForeignKey("FacultyId")]
    [InverseProperty("Courses")]
    public virtual Faculty? Faculty { get; set; }

    [InverseProperty("Course")]
    public virtual ICollection<Module> Modules { get; set; } = new List<Module>();
}
