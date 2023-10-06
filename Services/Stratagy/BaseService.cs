using AutoMapper;
using Library;
using Services.dto;
using Services.dto.BaseDto;

namespace Services.Stratagy;

public class BaseService<TEntity,TDto> 
    where TDto : BaseDto
    where TEntity : BaseEntity
{
    protected IUnitOfWork _unitOfWork; 
    protected IMapper _mapper;
    
    public BaseService( IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

}