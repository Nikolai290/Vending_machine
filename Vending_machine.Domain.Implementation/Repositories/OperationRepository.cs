﻿using Microsoft.EntityFrameworkCore;
using Vending_machine.Domain.Interfaces.Repositories;
using Vending_machine.Entities;

namespace Vending_machine.Domain.Implementation.Repositories;

public class OperationRepository : BaseCrudRepository<Operation>, IOperationRepostory
{
    public OperationRepository(DbContext dbContext) : base(dbContext)
    {
    }

    public async Task<int> GetCustomerRepositoryAsync(CancellationToken cancellationToken)
    {
        var result = await _dbSet
            .OrderByDescending(operation => operation.OperationDatetime)
            .Take(1)
            .SingleAsync(cancellationToken);
        
        return result.CustomerBalance;
    }
}