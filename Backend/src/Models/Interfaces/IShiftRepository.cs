using Backend.Models.DTOs;

namespace Backend.Models.Interfaces;

public interface IShiftRepository
{
    Task<List<ListOfShiftsResponseDTO>> ListShifts();
    Task AddShift(ShiftRequestDTO shiftRequestDTO);
}
