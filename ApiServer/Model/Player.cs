using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiServer.Model
{
    // Note: 무기 이외에 방어구가 추가되거나 일반 스테이지 이외에 미션과 같은 스테이지 생성 시 테이블을 분리해야 한다.
    [Table("t_player")]
    public class Player
    {
        [Key]
        [Column("aid")]
        public long AccountId { get; set; }

        [Column("equip_weapon_id")]
        public int EquipWeaponId { get; set; }

        [Column("completed_stage")]
        public int CompletedStage { get; set; }

        [Column("update_time")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime UpdateTime { get; set; }
    }
}
