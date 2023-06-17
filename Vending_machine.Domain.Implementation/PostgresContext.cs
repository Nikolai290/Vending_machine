﻿using Microsoft.EntityFrameworkCore;
using Vending_machine.Domain.Interfaces;
using Vending_machine.Domain.Settings;
using Vending_machine.Entities;

namespace Vending_machine.Domain.Implementation;

public class PostgresContext : DbContext, IDbContext
{
    private readonly DbSettings _dbSettings;
    
    public DbSet<Coin> Coins { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Manufacturer> Manufacturers { get; set; }

    public PostgresContext()
    {
        _dbSettings = new DbSettings()
        {
            ConnectionString = @"Host=localhost;Port=5432;User ID=postgres;Password=123;Database=vending_machine;"
        };
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(_dbSettings.ConnectionString);
    }
}