using Vending_machine.Business.Dtos.ManufacturerDtos;

namespace Vending_machine.Business.Interfaces.Services;

public interface IManufacturerService : IBaseCrudService<ManufacturerCreateDto, ManufacturerUpdateDto, ManufacturerOutDto>
{
    
}