using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Jet_Skills_SMS_.Models;

[Index("Email", Name = "UQ__Lecturer__AB6E61640D7E42F3", IsUnique = true)]
public partial class Lecturer
{
    [Key]
    [Column("lecturer_id")]
    public int LecturerId { get; set; }

    [Column("first_name")]
    [StringLength(50)]
    [Unicode(false)]
    public string? FirstName { get; set; }

    [Column("last_name")]
    [StringLength(50)]
    [Unicode(false)]
    public string? LastName { get; set; }

    [Column("email")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Email { get; set; }

    [Column("phone_number")]
    [StringLength(20)]
    [Unicode(false)]
    public string? PhoneNumber { get; set; }

    [Column("faculty_id")]
    [StringLength(15)]
    [Unicode(false)]
    public string? FacultyId { get; set; }

    [Column("password")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Password { get; set; }

    [Column("user_type")]
    public int? UserType { get; set; }

    [ForeignKey("FacultyId")]
    [InverseProperty("Lecturers")]
    public virtual Faculty? Faculty { get; set; }

    [InverseProperty("Lecturer")]
    public virtual ICollection<LecturerModule> LecturerModules { get; set; } = new List<LecturerModule>();

    [ForeignKey("UserType")]
    [InverseProperty("Lecturers")]
    public virtual UserType? UserTypeNavigation { get; set; }
}
