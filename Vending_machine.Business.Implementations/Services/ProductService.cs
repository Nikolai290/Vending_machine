using AutoMapper;
using Vending_machine.Business.Dtos.ProductDtos;
using Vending_machine.Business.Interfaces.Services;
using Vending_machine.Domain.Interfaces.Repositories;
using Vending_machine.Entities;

namespace Vending_machine.Business.Implementations.Services;

public class ProductService : BaseCrudService<Product, ProductCreateDto, ProductUpdateDto, ProductOutDto>, IProductService
{
    public ProductService(IBaseCrudRepository<Product> repository, IMapper mapper) : base(repository, mapper)
    {
    }
}