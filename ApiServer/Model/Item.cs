using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;
using System.Xml.Linq;

namespace ApiServer.Model
{
    [Table("t_item")]
    [Index(nameof(AcocuntId))]
    public class Item
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }

        [Column("account_id")]
        public long AcocuntId { get; set; }

        [Column("item_type")]
        public byte ItemType { get; set; }

        [Column("item_id")]
        public int ItemId { get; set; }

        [Column("count")]
        public int Count { get; set; }

        [Column("update_time")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime UpdateTime { get; set; }
    }
}
