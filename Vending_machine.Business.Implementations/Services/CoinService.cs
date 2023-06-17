using AutoMapper;
using Vending_machine.Business.Dtos.CoinDtos;
using Vending_machine.Business.Interfaces.Services;
using Vending_machine.Domain.Interfaces.Repositories;
using Vending_machine.Entities;

namespace Vending_machine.Business.Implementations.Services;

public class CoinService : BaseCrudService<Coin, CoinCreateDto, CoinUpdateDto, CoinOutDto>, ICoinService
{
    public CoinService(IBaseCrudRepository<Coin> repository, IMapper mapper) : base(repository, mapper)
    {
    }
}