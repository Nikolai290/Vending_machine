using System.Linq.Expressions;

namespace Vending_machine.Domain.Interfaces.Repositories;

public interface IBaseCrudRepository<TEntity> : IDisposable
{
    Task<IEnumerable<TEntity>> GetAsync(
        Expression<Func<TEntity, bool>> filter = null,
        Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
        string includeProperties = "");
    Task<TEntity> GetByIdAsync(int id, CancellationToken cancellationToken);
    Task<IEnumerable<TEntity>> GetAllAsync(CancellationToken cancellationToken);
    Task<TEntity> CreateAsync(TEntity obj, CancellationToken cancellationToken);
    Task<TEntity> UpdateAsync(TEntity obj, CancellationToken cancellationToken);
    Task<bool> DeleteAsync(int id, CancellationToken cancellationToken);
}