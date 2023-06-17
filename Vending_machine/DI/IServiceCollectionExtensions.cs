using Microsoft.EntityFrameworkCore;
using Vending_machine.Domain.Implementation;
using Vending_machine.Domain.Implementation.Repositories;
using Vending_machine.Domain.Interfaces.Repositories;

namespace Vending_machine.DI;

public static class IServiceCollectionExtensions
{
    public static void AddRepositories(this IServiceCollection services)
    {
        services.AddScoped<DbContext, PostgresContext>();
        services.AddScoped<ICoinRepository, CoinRepository>();
        services.AddScoped<IProductRepository, ProductRepository>();
        services.AddScoped<IManufacturerRepository, ManufactorerRepository>();
    }

    public static void AddServices(this IServiceCollection services)
    {
        
    }
}