using Vending_machine.Entities;

namespace Vending_machine.Domain.Interfaces.Repositories;

public interface ICoinTypeRepository : IBaseCrudRepository<CoinType>
{
    Task<int> GetVendingBalanceAsync(CancellationToken cancellationToken);

}