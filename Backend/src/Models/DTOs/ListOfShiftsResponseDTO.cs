namespace Backend.Models.DTOs;

public class ListOfShiftsResponseDTO
{
    public int Id { get; set; }
    public required int TimeStart { get; set; }

    public required DateOnly DateOfShift { get; set; }

    public int AppUserId { get; set; }
    public required UserBasicInfoDTO AppUser { get; set; }
}
