using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System;

namespace ApiServer.Model
{
    [Table("t_weapon")]
    [Index(nameof(AcocuntId))]
    public class Weapon
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }

        [Column("account_id")]
        public long AcocuntId { get; set; }

        [Column("weapon_id")]
        public int WeaponId { get; set; }

        [Column("level")]
        public int Level { get; set; }

        [Column("update_time")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime UpdateTime { get; set; }
    }
}
