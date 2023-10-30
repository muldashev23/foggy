namespace Backend.Models.DTOs;

public class UserBasicInfoDTO
{
    public int Id { get; set; }
    public required string Email { get; set; }
    public required string FirstName { get; set; }
    public required string SurName { get; set; }
    public required string Role { get; set; }
    public required bool IsBarmen { get; set; }
    public required bool IsShishaMaster { get; set; }
}
