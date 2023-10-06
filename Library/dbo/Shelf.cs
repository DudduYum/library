using System.ComponentModel.DataAnnotations.Schema;

namespace Library;

[Table("Shelf")]
public class Shelf: BaseContainer
{
    public virtual List<Folder> Folders { get; set; }
}