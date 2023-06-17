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
        CreateMap<CoinCreateDto, Coin>();
        CreateMap<CoinUpdateDto, Coin>();
        CreateMap<Coin, CoinOutDto>();

        CreateMap<ProductCreateDto, Product>();
        CreateMap<ProductUpdateDto, Product>();
        CreateMap<Product, ProductOutDto>();
        CreateMap<Product, ProductShortOutDto>();

        CreateMap<ManufacturerCreateDto, Manufacturer>();
        CreateMap<ManufacturerUpdateDto, Manufacturer>();
        CreateMap<Manufacturer, ManufacturerShortOutDto>();
        CreateMap<Manufacturer, ManufacturerOutDto>()
            .ForMember(dest => dest.ProductIds, 
            opt => opt
                .MapFrom((source,dest) =>  dest.ProductIds = source.Products.Select(x => x.Id).ToList()));
    }
}