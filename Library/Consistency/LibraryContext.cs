
using Microsoft.EntityFrameworkCore;

namespace Library;

public class LibraryContext : DbContext
{
    public DbSet<DocumentType> DocumentTypes { get; set; }
    public DbSet<Document> Documents { get; set; }
    public DbSet<Folder> Folders { get; set; }
    public DbSet<Shelf> Shelves { get; set; }
    public DbSet<User> Users { get; set; }

    public LibraryContext(DbContextOptions<LibraryContext> options) : base(options)
    {
    }

}
