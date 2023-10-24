namespace Backend.Models.DTOs;

public class LoginResponseDTO
{
    public required int Id { get; set; }
    public required string FirstName { get; set; }
    public required string Token { get; set; }
    public required bool IsAdmin { get; set; }

    public required bool IsManager { get; set; }
    public required bool IsBarmen { get; set; }
    public required bool IsShishaMaster { get; set; }
}
