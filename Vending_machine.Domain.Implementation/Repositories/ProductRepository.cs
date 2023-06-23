using Microsoft.EntityFrameworkCore;
using Vending_machine.Domain.Interfaces.Repositories;
using Vending_machine.Entities;

namespace Vending_machine.Domain.Implementation.Repositories;

public class ProductRepository : BaseCrudRepository<Product>, IProductRepository
{
    public ProductRepository(PostgresContext dbContext) : base(dbContext)
    {
    }
}