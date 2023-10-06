namespace Library;

public class BaseContainer : BaseEntity, IContainer
{
    public bool isFull { get; set; }
    
    public bool IsFull()
    {
        return isFull;
    }
}