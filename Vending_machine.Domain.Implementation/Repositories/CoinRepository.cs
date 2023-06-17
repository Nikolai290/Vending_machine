using Microsoft.EntityFrameworkCore;
using Vending_machine.Domain.Interfaces.Repositories;
using Vending_machine.Entities;

namespace Vending_machine.Domain.Implementation.Repositories;

public class CoinRepository : BaseCrudRepository<Coin>, ICoinRepository
{
    public CoinRepository(DbContext dbDBcontext) : base(dbDBcontext)
    {
    }
}