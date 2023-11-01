using Library;
using Microsoft.AspNetCore.Mvc;

namespace Portal.Controllers;

public class EntityCRUDController<TEntyty> :  Controller where TEntyty : BaseEntity
{
    private IUnitOfWork _unitOfWork;

    public EntityCRUDController(IUnitOfWork unitOfWork) : base()
    {
        _unitOfWork = unitOfWork;
    }
    public void Create(TEntyty entity)
    {
        
    }
    
    // public void Edit (TEntyty entity)
}