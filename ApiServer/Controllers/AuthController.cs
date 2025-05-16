using ApiServer.Model;
using ApiServer.Model.DTO;
using ApiServer.Repository.DB.Interface;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ApiServer.Controllers;

[ApiController]
[Route("api/auth")]
public class AuthController(IAuthRepository repo, IMapper mapper) : Controller
{
    private readonly IAuthRepository _authRepo = repo;
    private readonly IMapper _mapper = mapper;
    private readonly ApiResponse _response = new();

    /// <summary>
    /// 계정 생성
    /// </summary>
    [HttpPost("create")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> CreateAccount([FromBody] CreateAccountDTO reqDto)
    {
        try
        {
            var account = await _authRepo.GetAccount(reqDto.Email);
            if (account  != null)
            {
                _response.IsSuccess = false;
                _response.ErrorCode = ErrorCode.EmailAlreadyExists;
                return BadRequest(_response);
            }

            var hasher = new PasswordHasher<Account>();
            var encryptedPassword = hasher.HashPassword(new Account(), reqDto.Password);

            account = new Account
            {
                Email = reqDto.Email,
                Password = encryptedPassword
            };

            await _authRepo.CreateAsync(account);

            return Ok(_response);
        }
        catch(Exception e)
        {
            _response.IsSuccess = false;
            _response.ErrorCode = ErrorCode.InternalServerError;
            _response.ErrorMessage = e.ToString();

            return StatusCode(500, _response);
        }
    }

    /// <summary>
    /// 로그인
    /// </summary>
    [HttpPost("login")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> Login([FromBody] LoginRequestDTO reqDto)
    {
        try
        {
            var account = await _authRepo.GetAccount(reqDto.Email);
            if (account is null)
            {
                _response.ErrorCode = ErrorCode.AccountNotExist;
                _response.IsSuccess = false;
                return BadRequest(_response);
            }

            var hasher = new PasswordHasher<Account>();
            var result = hasher.VerifyHashedPassword(new Account(), account.Password, reqDto.Password);

            if (result == PasswordVerificationResult.Failed)
            {
                _response.ErrorCode = ErrorCode.IncorrectPassword;
                _response.IsSuccess = false;
                return BadRequest(_response);
            }
                            
            account.LastLoginTime = DateTime.UtcNow;
            await _authRepo.Update(account);

            _response.Result = _mapper.Map<LoginResponseDTO>(account);
            return Ok(_response);

        }
        catch(Exception e)
        {
            _response.IsSuccess = false;
            _response.ErrorCode = ErrorCode.InternalServerError;
            _response.ErrorMessage = e.ToString();

            return StatusCode(500, _response);
        }
    }
}
