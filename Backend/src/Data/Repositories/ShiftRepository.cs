using AutoMapper;
using AutoMapper.QueryableExtensions;
using Backend.Data.Entities;
using Backend.Models.DTOs;
using Backend.Models.Interfaces;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Backend.Data.Repositories;

public class ShiftRepository : IShiftRepository
{
    private readonly DataContext _context;
    private readonly IMapper _mapper;

    public ShiftRepository(DataContext dataContext, IMapper mapper)
    {
        _context = dataContext;
        _mapper = mapper;
    }

    public async Task<List<ListOfShiftsResponseDTO>> ListShifts()
    {
        var listOfShifts = await _context.Shifts
            .ProjectTo<ListOfShiftsResponseDTO>(_mapper.ConfigurationProvider)
            .ToListAsync();
        return listOfShifts;
    }

    public async Task AddShift(ShiftRequestDTO shiftRequestDTO)
    {
        var user = await _context.Users.SingleOrDefaultAsync(
            user => user.Id == shiftRequestDTO.UserId
        );
        var shift = new Shift
        {
            DayNum = shiftRequestDTO.DayNum,
            WeekNum = shiftRequestDTO.WeekNum,
            TimeStart = shiftRequestDTO.TimeStart,
            AppUser = user,
            DateOfShift = shiftRequestDTO.DateOfShift
        };
        await _context.Shifts.AddAsync(shift);
        await _context.SaveChangesAsync();
        return;
    }
}
