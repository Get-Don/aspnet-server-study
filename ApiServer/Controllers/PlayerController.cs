using Microsoft.AspNetCore.Mvc;

namespace ApiServer.Controllers;

[ApiController]
[Route("api/player")]
public class PlayerController : Controller
{
    /// <summary>
    /// 플레이어 정보 요청
    /// </summary>
    [HttpPost("info")]
    public async Task PlayerInfo()
    {

    }
}
