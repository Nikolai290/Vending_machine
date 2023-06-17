using Vending_machine.Business.Dtos.ProductDtos;
using Vending_machine.Business.Interfaces.Services;

namespace Vending_machine.Controllers;

public class ProductController : BaseCrudController<ProductCreateDto, ProductUpdateDto, ProductOutDto>
{
    private readonly IProductService _productService;

    public ProductController(IProductService productService) : base(productService)
    {
        _productService = productService;
    }
}