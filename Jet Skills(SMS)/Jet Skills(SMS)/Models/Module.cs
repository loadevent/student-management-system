using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Jet_Skills_SMS_.Models;

public partial class Module
{
    [Key]
    [Column("module_id")]
    [StringLength(20)]
    [Unicode(false)]
    public string ModuleId { get; set; } = null!;

    [Column("module_name")]
    [StringLength(100)]
    [Unicode(false)]
    public string ModuleName { get; set; } = null!;

    [Column("course_id")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CourseId { get; set; }

    [Column("semester")]
    public int? Semester { get; set; }

    [ForeignKey("CourseId")]
    [InverseProperty("Modules")]
    public virtual Course? Course { get; set; }

    [InverseProperty("Module")]
    public virtual ICollection<LecturerModule> LecturerModules { get; set; } = new List<LecturerModule>();
}
