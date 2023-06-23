using Microsoft.EntityFrameworkCore;
using Vending_machine.Domain.Interfaces.Repositories;
using Vending_machine.Entities;

namespace Vending_machine.Domain.Implementation.Repositories;

public class OperationRepository : BaseCrudRepository<Operation>, IOperationRepostory
{
    public OperationRepository(PostgresContext dbContext) : base(dbContext)
    {
    }

    public async Task<int> GetCustomerRepositoryAsync(CancellationToken cancellationToken)
    {
        if (!_dBcontext.Operations.Any())
        {
            return 0;
        }
        
        var result = await _dBcontext.Operations
            .OrderByDescending(operation => operation.OperationDatetime)
            .Take(1)
            .SingleAsync(cancellationToken);
        
        return result.CustomerBalance;
    }
}