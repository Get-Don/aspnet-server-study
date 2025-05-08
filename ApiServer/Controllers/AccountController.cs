using ApiServer.Model.DTO;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace ApiServer.Controllers
{
    [ApiController]
    [Route("api/account")]
    public class AccountController
    {
        /// <summary>
        /// 계정 생성
        /// </summary>
        [HttpPost("create")]
        public async Task CreateAccount([FromBody] CreateAccountDTO reqDto)
        {
        }

        /// <summary>
        /// 로그인
        /// </summary>
        [HttpPost("login")]
        public async Task Login([FromBody] LoginRequestDTO reqDto)
        {
        }
    }
}
