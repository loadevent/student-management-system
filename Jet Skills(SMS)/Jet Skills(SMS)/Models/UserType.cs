using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Jet_Skills_SMS_.Models;

[Table("UserType")]
public partial class UserType
{
    [Key]
    [Column("user_type_id")]
    public int UserTypeId { get; set; }

    [Column("description")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Description { get; set; }

    [InverseProperty("UserTypeNavigation")]
    public virtual ICollection<Lecturer> Lecturers { get; set; } = new List<Lecturer>();

    [InverseProperty("UserTypeNavigation")]
    public virtual ICollection<Student> Students { get; set; } = new List<Student>();
}
