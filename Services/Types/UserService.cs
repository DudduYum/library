using AutoMapper;
using Library;
using Services.dto;
using Services.Stratagy;

namespace Services;

public class UserrService: BaseService<User, UserDto>
{
    public UserrService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
    {
    }
    
    
}