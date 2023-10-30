using System.Security.Cryptography;
using System.Text;
using Backend.Models.DTOs;
using Backend.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers;

public class AccountController : BaseApiController
{
    private readonly IAccountRepository _accountRepository;

    public AccountController(IAccountRepository accountRepository)
    {
        _accountRepository = accountRepository;
    }

    [HttpPost("login")]
    public async Task<ActionResult<LoginResponseDTO>> Login(
        [FromBody] LoginRequestDTO loginRequestDTO
    )
    {
        if (await _accountRepository.VerifyUser(loginRequestDTO.Email) == false)
        {
            return Unauthorized("User doesn't exists");
        }
        var user = await _accountRepository.GetUser(loginRequestDTO);
        using var hmac = new HMACSHA512(user.PasswordSalt);
        var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(loginRequestDTO.Password));
        for (int i = 0; i < computedHash.Length; i++)
        {
            if (computedHash[i] != user.PasswordHash[i])
                return Unauthorized("Invalid Password!");
        }
        return _accountRepository.ResponseForLogin(user);
    }
}
