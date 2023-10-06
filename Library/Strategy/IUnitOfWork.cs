namespace Library;

public interface IUnitOfWork : IDisposable
{
    public IRepository<Document> Documents { get; }
    public IRepository<DocumentType> DocumentTypes { get; }
    public IRepository<Folder> Folders { get; }
    public IRepository<Shelf> Shelves { get; }

    public IRepository<User> Users { get; }
    
    int Compleate();
}