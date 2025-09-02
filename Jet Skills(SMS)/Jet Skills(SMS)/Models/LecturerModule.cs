using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Jet_Skills_SMS_.Models;

[Table("LecturerModule")]
public partial class LecturerModule
{
    [Key]
    [Column("assignment_id")]
    public int AssignmentId { get; set; }

    [Column("module_id")]
    [StringLength(20)]
    [Unicode(false)]
    public string? ModuleId { get; set; }

    [Column("lecturer_id")]
    public int? LecturerId { get; set; }

    [Column("academic_year")]
    [StringLength(20)]
    [Unicode(false)]
    public string? AcademicYear { get; set; }

    [ForeignKey("LecturerId")]
    [InverseProperty("LecturerModules")]
    public virtual Lecturer? Lecturer { get; set; }

    [ForeignKey("ModuleId")]
    [InverseProperty("LecturerModules")]
    public virtual Module? Module { get; set; }
}
