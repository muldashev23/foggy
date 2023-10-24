using AutoMapper;
using Backend.Data.Entities;
using Backend.Models.DTOs;

namespace Backend.Services;

public class MapperConfig : Profile
{
    public MapperConfig()
    {
        CreateMap<AppUser, UserDTO>();
        CreateMap<Shift, ListOfShiftsResponseDTO>();
        CreateMap<AppUser, UserBasicInfoDTO>();
    }
}
