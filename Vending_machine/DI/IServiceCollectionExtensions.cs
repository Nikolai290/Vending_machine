using Microsoft.EntityFrameworkCore;
using Vending_machine.Business.Dtos.CoinDtos;
using Vending_machine.Business.Dtos.ManufacturerDtos;
using Vending_machine.Business.Dtos.ProductDtos;
using Vending_machine.Business.Implementations.Services;
using Vending_machine.Business.Interfaces.Services;
using Vending_machine.Domain.Implementation;
using Vending_machine.Domain.Implementation.Repositories;
using Vending_machine.Domain.Interfaces.Repositories;
using Vending_machine.Entities;

namespace Vending_machine.DI;

public static class IServiceCollectionExtensions
{
    public static void AddRepositories(this IServiceCollection services)
    {
        services.AddScoped<DbContext, PostgresContext>();

        services.AddScoped<IBaseCrudRepository<Coin>, BaseCrudRepository<Coin>>();
        services.AddScoped<IBaseCrudRepository<Product>, BaseCrudRepository<Product>>();
        services.AddScoped<IBaseCrudRepository<Manufacturer>, BaseCrudRepository<Manufacturer>>();
        
        services.AddScoped<ICoinRepository, CoinRepository>();
        services.AddScoped<IProductRepository, ProductRepository>();
        services.AddScoped<IManufacturerRepository, ManufactorerRepository>();
    }

    public static void AddServices(this IServiceCollection services)
    {
        services.AddScoped<IBaseCrudService<CoinCreateDto, CoinUpdateDto, CoinOutDto>, CoinService>();
        services.AddScoped<IBaseCrudService<ProductCreateDto, ProductUpdateDto, ProductOutDto>, ProductService>();
        services.AddScoped<IBaseCrudService<ManufacturerCreateDto, ManufacturerUpdateDto, ManufacturerOutDto>, ManufacturerService>();
        
        services.AddScoped<ICoinService, CoinService>();
        services.AddScoped<IProductService, ProductService>();
        services.AddScoped<IManufacturerService, ManufacturerService>();
    }
}