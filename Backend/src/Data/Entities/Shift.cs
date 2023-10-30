using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Data.Entities;

public class Shift
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public required int DayNum { get; set; }
    public required int TimeStart { get; set; }
    public required int WeekNum { get; set; }
    public required DateOnly DateOfShift { get; set; }

    public int AppUserId { get; set; }
    public required AppUser AppUser { get; set; }
}
