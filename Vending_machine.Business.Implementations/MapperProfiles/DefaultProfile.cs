using AutoMapper;
using Vending_machine.Business.Dtos.CoinDtos;
using Vending_machine.Business.Dtos.ManufacturerDtos;
using Vending_machine.Business.Dtos.ProductDtos;
using Vending_machine.Entities;

namespace Vending_machine.Business.Implementations.MapperProfiles;

public class DefaultProfile : Profile
{
    public DefaultProfile()
    {
        CreateMap<CoinTypeCreateDto, CoinType>();
        CreateMap<CoinTypeUpdateDto, CoinType>();
        CreateMap<CoinType, CoinTypeOutDto>();

        CreateMap<ProductCreateDto, Product>();
        CreateMap<ProductUpdateDto, Product>();
        CreateMap<Product, ProductOutDto>();
        CreateMap<Product, ProductShortOutDto>();

        CreateMap<ManufacturerCreateDto, Manufacturer>();
        CreateMap<ManufacturerUpdateDto, Manufacturer>();
        CreateMap<Manufacturer, ManufacturerShortOutDto>();
        CreateMap<Manufacturer, ManufacturerOutDto>();
    }
}