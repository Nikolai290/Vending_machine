using AutoMapper;
using Vending_machine.Business.Dtos.ManufacturerDtos;
using Vending_machine.Business.Interfaces.Services;
using Vending_machine.Domain.Interfaces.Repositories;
using Vending_machine.Entities;

namespace Vending_machine.Business.Implementations.Services;

public class ManufacturerService : BaseCrudService<Manufacturer, ManufacturerCreateDto, ManufacturerUpdateDto, ManufacturerOutDto>, IManufacturerService
{
    public ManufacturerService(IBaseCrudRepository<Manufacturer> repository, IMapper mapper) : base(repository, mapper)
    {
    }
}