using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
namespace Jet_Skills_SMS_.Models
{
    public partial class Admin
    {
        [Key]
        [Column("admin_id")]
        public int AdminId { get; set; }

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

        [Column("password")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Password { get; set; }

        [Column("phone_number")]
        [StringLength(20)]
        [Unicode(false)]
        public string? PhoneNumber { get; set; }

        [Column("user_type")]
        public int? UserType { get; set; }
        [ForeignKey("UserType")]
        [InverseProperty("Admins")]
        public virtual UserType? UserTypeNavigation { get; set; }

    }
}
