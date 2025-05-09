using ApiServer.Model.DTO;
using Microsoft.AspNetCore.Mvc;

namespace ApiServer.Controllers
{
    [ApiController]
    [Route("api/item")]
    public class ItemController
    {
        /// <summary>
        /// 무기 장착
        /// </summary>
        [HttpPost("equip-weapon")]
        public async Task EquipWeapon([FromBody] EquipWeaponDTO reqDto)
        {

        }

        /// <summary>
        /// 무기 업그레이드
        /// </summary>
        [HttpPost("upgrade-weapon")]
        public async Task UpgradeWeapon([FromBody] UpgradeWeaponDTO reqDto)
        {

        }
    }
}
