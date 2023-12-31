﻿using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Vending_machine.Domain.Interfaces.Repositories;
using Vending_machine.Entities;

namespace Vending_machine.Domain.Implementation.Repositories;

public class BaseCrudRepository<TEntity> : IBaseCrudRepository<TEntity> where TEntity : BaseDbEntity
{
    private bool disposed = false;
    
    protected readonly PostgresContext _dBcontext;

    protected readonly DbSet<TEntity> _dbSet;

    public BaseCrudRepository(PostgresContext dbContext)
    {
        _dBcontext = dbContext;
        _dbSet = dbContext.Set<TEntity>();
    }
    
    public virtual async Task<IEnumerable<TEntity>> GetAsync(
        Expression<Func<TEntity, bool>> filter = null,
        Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
        string includeProperties = "")
    {
        IQueryable<TEntity> query = _dbSet;

        if (filter != null)
        {
            query = query.Where(filter);
        }

        foreach (var includeProperty in includeProperties.Split
                     (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
        {
            query = query.Include(includeProperty);
        }

        if (orderBy != null)
        {
            return await orderBy(query).ToListAsync();
        }
        else
        {
            return await query.ToListAsync();
        }
    }

    public virtual async Task<TEntity> GetByIdAsync(int id, CancellationToken cancellationToken)
    {
        return await _dbSet.SingleAsync(x => x.Id == id, cancellationToken);
    }

    public async Task<IEnumerable<TEntity>> GetAllAsync(CancellationToken cancellationToken)
    {
        return await _dbSet.OrderBy(x => x.Id).ToListAsync(cancellationToken);
    }

    public virtual async Task<TEntity> CreateAsync(TEntity obj, CancellationToken cancellationToken)
    {
        var result = await _dbSet.AddAsync(obj, cancellationToken);
        return result.Entity;
    }

    public virtual async Task<TEntity> UpdateAsync(TEntity obj, CancellationToken cancellationToken)
    {
        var result = _dbSet.Update(obj);
        return result.Entity;
    }

    public async Task UpdateRangeAsync(IEnumerable<TEntity> obj, CancellationToken cancellationToken)
    {
        _dbSet.UpdateRange(obj);
        await _dBcontext.SaveChangesAsync(cancellationToken);
    }

    public virtual async Task<bool> DeleteAsync(int id, CancellationToken cancellationToken)
    {
        try
        {
            var forRemove = await GetByIdAsync(id, cancellationToken);
            _dbSet.Remove(forRemove);
            return true;
        }
        catch
        {
            return false;
        }

    }
    
    public async Task SaveAsync(CancellationToken cancellationToken)
    {
         await _dBcontext.SaveChangesAsync(cancellationToken);
    }

    protected void Dispose(bool disposing)
    {
        if (!disposed)
        {
            if (disposing)
            {
                _dBcontext.Dispose();
            }
        }
        disposed = true;
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
}