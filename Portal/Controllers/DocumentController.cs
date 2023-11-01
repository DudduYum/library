using Library;
using Microsoft.AspNetCore.Mvc;

namespace Portal.Controllers;

[ApiController]
[Route("[controller]")]
public class DocumentController : EntityCRUDController<Document> 
{
    public DocumentController(IUnitOfWork unitOfWork) : base(unitOfWork)
    {}
    
    public IEnumerable<Document> index
}