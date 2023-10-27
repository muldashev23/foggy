using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Backend.Data.Entities;

public class AppUser
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    public required string FirstName { get; set; }

    [Required]
    public required string Surname { get; set; }

    [Required]
    public required string Email { get; set; }

    public byte[] PasswordHash { get; set; }

    public byte[] PasswordSalt { get; set; }

    [Required]
    public required string Role { get; set; }

    [JsonIgnore]
    public List<Shift> Shift { get; set; }

    [Required]
    public required bool IsBarmen { get; set; }

    [Required]
    public required bool IsShishaMaster { get; set; }
}
