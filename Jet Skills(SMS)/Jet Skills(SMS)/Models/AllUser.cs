using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Jet_Skills_SMS_.Models;

[PrimaryKey("UserId", "Email")]
public partial class AllUser
{
    [Key]
    [Column("user_id")]
    public int UserId { get; set; }

    [Key]
    [Column("email")]
    [StringLength(50)]
    [Unicode(false)]
    public string Email { get; set; } = null!;

    [Column("phone")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Phone { get; set; }

    [Column("password")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Password { get; set; }

    [Column("user_type")]
    public int? UserType { get; set; }

    [ForeignKey("UserType")]
    [InverseProperty("AllUsers")]
    public virtual UserType? UserTypeNavigation { get; set; }
}
