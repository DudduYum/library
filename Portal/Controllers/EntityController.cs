using Library;
using Microsoft.AspNetCore.Mvc;

namespace Portal.Controllers;

public class EntityCRUDController<TEntyty> : Controller where TEntyty : BaseEntity
{
    public void Create(TEntyty entity)
    {
        
    }
    
    // public void Edit (TEntyty entity)
}