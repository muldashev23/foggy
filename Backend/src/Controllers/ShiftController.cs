using Backend.Models.DTOs;
using Backend.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers;

public class ShiftController : BaseApiController
{
    private readonly IShiftRepository _shiftRepository;

    public ShiftController(IShiftRepository shiftRepository)
    {
        _shiftRepository = shiftRepository;
    }

    [HttpGet]
    public async Task<List<ListOfShiftsResponseDTO>> ListShifts()
    {
        return await _shiftRepository.ListShifts();
    }

    [HttpPost]
    public async Task<ActionResult> AddShift([FromBody] ShiftRequestDTO shiftRequestDTO)
    {
        await _shiftRepository.AddShift(shiftRequestDTO);
        return Ok();
    }
}
