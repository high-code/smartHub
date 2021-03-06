using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using SmartHub.DataAccess.Contracts;

namespace SmartHub.DataAccess.Concrete
{
  public class Repository<TContext, TEntity> : IRepository<TContext, TEntity> where TContext : DbContext
                                                                              where TEntity : class
  {
    public TContext Context => DbContext;

    protected TContext DbContext;

    public Repository(TContext dbContext)
    {
      DbContext = dbContext;
    }

    public TEntity Get(int id) => DbContext.Set<TEntity>().Find(id);

    public IEnumerable<TEntity> GetAll() => DbContext.Set<TEntity>().ToList();

    public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate) => DbContext.Set<TEntity>().Where(predicate);

    public void Add(TEntity entity) => DbContext.Add(entity);

    public void AddRange(IEnumerable<TEntity> entities) => DbContext.AddRange(entities);

    public void Remove(TEntity entity) => DbContext.Remove(entity);

    public void RemoveRange(IEnumerable<TEntity> entities) => DbContext.RemoveRange(entities);
  }
}
