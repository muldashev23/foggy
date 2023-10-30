using AutoMapper;
using AutoMapper.QueryableExtensions;
using Backend.Models.DTOs;
using Backend.Models.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Backend.Data.Repositories;

public class AccountRepository : IAccountRepository
{
    private readonly DataContext _context;
    private readonly IMapper _mapper;
    private readonly ITokenService _tokenService;

    public AccountRepository(DataContext context, IMapper autoMapper, ITokenService tokenService)
    {
        _context = context;
        _mapper = autoMapper;
        _tokenService = tokenService;
    }

    public async Task<bool> VerifyUser(string email)
    {
        return await _context.Users.AnyAsync(user => user.Email == email.ToLower());
    }

    public async Task<UserDTO> GetUser(LoginRequestDTO loginRequestDTO)
    {
        return await _context.Users
            .ProjectTo<UserDTO>(_mapper.ConfigurationProvider)
            .SingleOrDefaultAsync(user => user.Email == loginRequestDTO.Email);
    }

    public LoginResponseDTO ResponseForLogin(UserDTO user)
    {
        return new LoginResponseDTO
        {
            Id = user.Id,
            FirstName = user.FirstName,
            Token = _tokenService.CreateToken(user),
            IsAdmin = user.Role == "Admin",
            IsManager = user.Role == "Manager",
            IsBarmen = user.IsBarmen,
            IsShishaMaster = user.IsShishaMaster
        };
    }
}
