using AutoMapper;
using Library;
using Services.dto;

namespace Services;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<UserDto, User>().ReverseMap();
    }
}