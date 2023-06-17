using Vending_machine.Business.Dtos.CoinDtos;

namespace Vending_machine.Business.Interfaces.Services;

public interface ICoinService : IBaseCrudService<CoinCreateDto, CoinUpdateDto, CoinOutDto>
{
    
}