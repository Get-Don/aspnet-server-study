using ApiServer.Model.DTO;
using Microsoft.AspNetCore.Mvc;

namespace ApiServer.Controllers
{
    [ApiController]
    [Route("api/stage")]
    public class StageController
    {
        /// <summary>
        /// 스테이지 시작
        /// </summary>
        [HttpPost("start")]
        public async Task StartStage([FromBody] StartStageDTO reqDto)
        {

        }

        /// <summary>
        /// 스테이지 종료(성공/실패/나가기)
        /// </summary>
        /// <returns></returns>
        [HttpPost("end")]
        public async Task EndStage([FromBody] EndStageDTO reqDto)
        {

        }
    }
}
