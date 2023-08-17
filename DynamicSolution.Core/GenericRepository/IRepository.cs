using DynamicSolution.DataAccess;

namespace DynamicSolution.Core.GenericRepository;
public interface IRepository<TEntity>
{
    TEntity GetById(int id);
    void Add(TEntity entity);
    void Update(TEntity entity);
    void Delete(TEntity entity);
}

public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
{
    protected readonly AppDbContext _dbContext;

    public Repository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public virtual IQueryable<TEntity> GetAll()
    {
        return _dbContext.Set<TEntity>();
    }

    public virtual TEntity GetById(int id)
    {
        return _dbContext.Set<TEntity>().Find(id);
    }

    public virtual void Add(TEntity entity)
    {
        _dbContext.Set<TEntity>().Add(entity);
        _dbContext.SaveChanges();
    }

    public virtual void Update(TEntity entity)
    {
        _dbContext.Set<TEntity>().Update(entity);
        _dbContext.SaveChanges();
    }

    public virtual void Delete(TEntity entity)
    {
        _dbContext.Set<TEntity>().Remove(entity);
        _dbContext.SaveChanges();
    }
}
