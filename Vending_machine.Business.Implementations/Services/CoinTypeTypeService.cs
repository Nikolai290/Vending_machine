using AutoMapper;
using Vending_machine.Business.Dtos.CoinDtos;
using Vending_machine.Business.Interfaces.Services;
using Vending_machine.Domain.Interfaces.Repositories;
using Vending_machine.Entities;

namespace Vending_machine.Business.Implementations.Services;

public class CoinTypeTypeService : BaseCrudService<CoinType, CoinTypeCreateDto, CoinTypeUpdateDto, CoinTypeOutDto>, ICoinTypeService
{
    public CoinTypeTypeService(IBaseCrudRepository<CoinType> repository, IMapper mapper) : base(repository, mapper)
    {
    }
}