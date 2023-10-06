using Microsoft.Extensions.Logging;

namespace Library;

public class UnitOfWork : IUnitOfWork
{
    public IRepository<Document> Documents { get; }
    public IRepository<DocumentType> DocumentTypes { get; }
    public IRepository<Folder> Folders { get; }
    public IRepository<Shelf> Shelves { get; }
    
    public IRepository<User> Users { get; }

    private readonly LibraryContext _context;
    private readonly ILogger _logger;

    public UnitOfWork(LibraryContext context, ILogger<UnitOfWork> logger)
    {
        _context = context;
        _logger = logger;
        
        Documents = new Repository<Document>(_context);
        DocumentTypes = new Repository<DocumentType>(_context);
        Folders = new Repository<Folder>(_context);
        Shelves = new Repository<Shelf>(_context);
        Users = new Repository<User>(_context);
        
        
        
        _logger.LogInformation("Works");
    }

    public int Compleate()
    {
        return _context.SaveChanges();
    }

    public void Dispose()
    {
        _context.Dispose();
    }
}