using ApiServer.Model.DTO;
using Microsoft.AspNetCore.Mvc;

namespace ApiServer.Controllers
{
    [ApiController]
    [Route("api/game")]
    public class GameController
    {
        /// <summary>
        /// 스테이지 시작
        /// </summary>
        [HttpPost("start-stage")]
        public async Task StartStage([FromBody] StartStageDTO reqDto)
        {

        }

        /// <summary>
        /// 스테이지 종료(성공/실패/나가기)
        /// </summary>
        /// <returns></returns>
        [HttpPost("end-stage")]
        public async Task EndStage([FromBody] EndStageDTO reqDto)
        {

        }

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
