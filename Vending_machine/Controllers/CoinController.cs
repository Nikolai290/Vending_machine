using Vending_machine.Business.Dtos.CoinDtos;
using Vending_machine.Business.Interfaces.Services;

namespace Vending_machine.Controllers;

public class CoinController : BaseCrudController<CoinCreateDto, CoinUpdateDto, CoinOutDto>
{
    private readonly ICoinService _coinService;

    public CoinController(ICoinService coinService) : base(coinService)
    {
        _coinService = coinService;
    }
}