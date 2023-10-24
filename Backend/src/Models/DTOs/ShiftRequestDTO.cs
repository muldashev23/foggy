using Backend.Data.Entities;

namespace Backend.Models.DTOs;

public class ShiftRequestDTO
{
    public required int DayNum { get; set; }
    public required int TimeStart { get; set; }
    public required int WeekNum { get; set; }
    public required DateOnly DateOfShift { get; set; }

    public required int UserId { get; set; }
}
