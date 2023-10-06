using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library;

[NotMapped]
public class BaseEntity 
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; }
    
    public DateTime CreationDate { get; init; }
    
    public Guid  FirstAuthorId { get; set; }
    [ForeignKey(nameof(FirstAuthorId))]
    public virtual User FirstAuthor { get; init; }
    
    public DateTime LastUpdate { get; set; }
    public Guid LastAuthorId { get; set; }
    [ForeignKey(nameof(LastAuthorId))]
    public virtual User LastAuthor { get; init; }
}