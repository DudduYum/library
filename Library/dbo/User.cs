namespace Library;

public class User : BaseEntity
{
    public Guid Id { get; set; }
    
    public string Name { get; set; }
    
    public Role Role { get; set; }
}