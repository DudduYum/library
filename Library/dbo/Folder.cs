using System.ComponentModel.DataAnnotations.Schema;

namespace Library;

[Table("Folder")]
public class Folder : BaseContainer 
{
    public String Color { get; set; }
    
    // public Blob Foto { get; set; }
    
    
    public Guid ShelfId { get; set; }
    public virtual Shelf Shelf { get; set; }
    
    public virtual List<Document> Documents { get; set; }
}