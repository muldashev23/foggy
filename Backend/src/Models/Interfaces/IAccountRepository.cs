using Backend.Models.DTOs;

namespace Backend.Models.Interfaces;

public interface IAccountRepository
{
    Task<bool> VerifyUser(string email);
    Task<UserDTO> GetUser(LoginRequestDTO loginRequestDTO);
    LoginResponseDTO ResponseForLogin(UserDTO user);
}
