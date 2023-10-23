using Backend.Models.DTOs;

namespace Backend;

public interface ITokenService
{
    string CreateToken(UserDTO user);
}
