using Vending_machine.Business.Dtos.ProductDtos;

namespace Vending_machine.Business.Interfaces.Services;

public interface IProductService : IBaseCrudService<ProductCreateDto, ProductUpdateDto, ProductOutDto>
{
    
}