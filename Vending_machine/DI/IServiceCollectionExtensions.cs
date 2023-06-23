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
        services.AddScoped<PostgresContext, PostgresContext>();

        services.AddScoped<IBaseCrudRepository<CoinType>, BaseCrudRepository<CoinType>>();
        services.AddScoped<IBaseCrudRepository<Product>, BaseCrudRepository<Product>>();
        services.AddScoped<IBaseCrudRepository<Manufacturer>, BaseCrudRepository<Manufacturer>>();
        
        services.AddScoped<ICoinTypeRepository, CoinTypeTypeRepository>();
        services.AddScoped<IProductRepository, ProductRepository>();
        services.AddScoped<IManufacturerRepository, ManufactorerRepository>();
        services.AddScoped<IOperationRepostory, OperationRepository>();
    }

    public static void AddServices(this IServiceCollection services)
    {
        services.AddScoped<IBaseCrudService<CoinTypeCreateDto, CoinTypeUpdateDto, CoinTypeOutDto>, CoinTypeTypeService>();
        services.AddScoped<IBaseCrudService<ProductCreateDto, ProductUpdateDto, ProductOutDto>, ProductService>();
        services.AddScoped<IBaseCrudService<ManufacturerCreateDto, ManufacturerUpdateDto, ManufacturerOutDto>, ManufacturerService>();
        
        services.AddScoped<ICoinTypeService, CoinTypeTypeService>();
        services.AddScoped<IProductService, ProductService>();
        services.AddScoped<IManufacturerService, ManufacturerService>();
        services.AddScoped<IOperationService, OperationService>();
    }
}