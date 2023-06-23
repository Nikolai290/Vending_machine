using Microsoft.EntityFrameworkCore;
using Vending_machine.Domain.Interfaces.Repositories;
using Vending_machine.Entities;

namespace Vending_machine.Domain.Implementation.Repositories;

public class ManufactorerRepository : BaseCrudRepository<Manufacturer>, IManufacturerRepository
{
    public ManufactorerRepository(PostgresContext dbContext) : base(dbContext)
    {
    }
}