using Vending_machine.Entities;

namespace Vending_machine.Domain.Interfaces.Repositories;

public interface IOperationRepostory : IBaseCrudRepository<Operation>
{
    Task<int> GetCustomerRepositoryAsync(CancellationToken cancellationToken);
}