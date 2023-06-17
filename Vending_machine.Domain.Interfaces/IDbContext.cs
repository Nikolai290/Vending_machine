using Microsoft.EntityFrameworkCore;
using Vending_machine.Entities;

namespace Vending_machine.Domain.Interfaces;

public interface IDbContext
{
    DbSet<Coin> Coins { get; set; }
    DbSet<Product> Products { get; set; }
    DbSet<Manufacturer> Manufacturers { get; set; }
}