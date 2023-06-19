using Vending_machine.Business.Dtos.CoinDtos;

namespace Vending_machine.Business.Interfaces.Services;

public interface ICoinTypeService : IBaseCrudService<CoinTypeCreateDto, CoinTypeUpdateDto, CoinTypeOutDto>
{
    
}