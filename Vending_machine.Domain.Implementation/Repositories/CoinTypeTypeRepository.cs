using Microsoft.EntityFrameworkCore;
using Vending_machine.Domain.Interfaces.Repositories;
using Vending_machine.Entities;

namespace Vending_machine.Domain.Implementation.Repositories;

public class CoinTypeTypeRepository : BaseCrudRepository<CoinType>, ICoinTypeRepository
{
    public CoinTypeTypeRepository(PostgresContext dbDBcontext) : base(dbDBcontext)
    {
    }

    public async Task<int> GetVendingBalanceAsync(CancellationToken cancellationToken)
    {
        return await _dbSet.SumAsync(coin => coin.Value * coin.Stock);
    }
}