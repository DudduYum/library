using System.ComponentModel.DataAnnotations.Schema;

namespace Library;

[Table("DocumentType")]
public class DocumentType: BaseEntity
{
    public String TypeName { get; set; }
}