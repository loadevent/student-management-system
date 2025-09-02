using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Jet_Skills_SMS_.Models;

public partial class Faculty
{
    [Key]
    [Column("faculty_id")]
    [StringLength(15)]
    [Unicode(false)]
    public string FacultyId { get; set; } = null!;

    [Column("faculty_name")]
    [StringLength(100)]
    [Unicode(false)]
    public string FacultyName { get; set; } = null!;

    [Column("dean_name")]
    [StringLength(100)]
    [Unicode(false)]
    public string? DeanName { get; set; }

    [InverseProperty("Faculty")]
    public virtual ICollection<Course> Courses { get; set; } = new List<Course>();

    [InverseProperty("Faculty")]
    public virtual ICollection<Lecturer> Lecturers { get; set; } = new List<Lecturer>();
}
