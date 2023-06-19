using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Vending_machine.Domain.Interfaces;
using Vending_machine.Domain.Settings;
using Vending_machine.Entities;

namespace Vending_machine.Domain.Implementation;

public class PostgresContext : DbContext, IDbContext
{
    private readonly DbSettings _dbSettings;
    
    public DbSet<CoinType> CoinTypes { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Manufacturer> Manufacturers { get; set; }
    public DbSet<Operation> Operations { get; set; }

    public PostgresContext(IOptions<DbSettings> options)
    {
        _dbSettings = new DbSettings()
        {
            ConnectionString = options.Value.ConnectionString
        };
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(_dbSettings.ConnectionString);
    }
}