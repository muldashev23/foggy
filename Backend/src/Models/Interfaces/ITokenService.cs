using Backend.Models.DTOs;

namespace Backend.Models.Interfaces;

public interface ITokenService
{
    string CreateToken(UserDTO user);
}
