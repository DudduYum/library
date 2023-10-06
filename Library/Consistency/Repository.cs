using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace Library;

public class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
{
    protected readonly DbContext _context;

    public Repository(DbContext context)
    {
        _context = context;
    }
    
    public TEntity? Get(Guid id)
    {
        return _context.Set<TEntity>().Find(id);
    }

    public IEnumerable<TEntity> GetAll()
    {
        return _context.Set<TEntity>().Where(x=> true).ToList();
    }

    public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
    {
        return _context.Set<TEntity>().Where(predicate).ToList();
    }

    public void Add(TEntity entiry)
    {
        _context.Set<TEntity>().Add(entiry);
    }

    public void AddRange(IEnumerable<TEntity> list)
    {
        _context.Set<TEntity>().AddRange(list);
    }

    public void Remove(TEntity entiry)
    {
        _context.Set<TEntity>().Remove(entiry);
    }

    public void RemoveRange(IEnumerable<TEntity> list)
    {
        _context.Set<TEntity>().RemoveRange(list);
    }
}