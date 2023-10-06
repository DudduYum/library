using System.Linq.Expressions;
using System.Net.Sockets;

namespace Library;

public interface IRepository<TEntity> where TEntity : BaseEntity
{
    public TEntity Get(Guid id);
    public IEnumerable<TEntity> GetAll();
    public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);

    public void Add(TEntity entiry);
    public void AddRange(IEnumerable<TEntity> list);

    public void Remove(TEntity entiry);
    public void RemoveRange(IEnumerable<TEntity> list);
}