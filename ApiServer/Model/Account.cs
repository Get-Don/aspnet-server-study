using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiServer.Model
{
    [Table("t_account")]
    [Index(nameof(Email), IsUnique = true)]
    public class Account
    {
        [Key]
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Required]
        [Column(name: "email", TypeName = "varchar(50)")]
        public string Email { get; set; }

        [Required]
        [Column("password", TypeName = "varchar(200)")]
        public string Password { get; set; }

        [Column("last_login_time")]
        public DateTime? LastLoginTime { get; set; }

        [Column("created_date")]
        public DateTime CreatedDate { get; set; }
    }
}
