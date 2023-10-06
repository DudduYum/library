using System.ComponentModel.DataAnnotations.Schema;

namespace Library;

[Table("Document")]
public class Document : BaseEntity
{
    public Guid FolderId { get; set; }

    public virtual Folder Folder { get; set; }

    public DocumentType DocumentType { get; set; }
    
    public string Title { get; set; }
    
    public string Description { get; set; }
    
    public DateTime YearOfRelevance { get; set; }
    
    //public foto
}